using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Net.NetworkInformation;
using System.Timers;
using System.Windows.Input;

namespace ServerBrowserApplication
{
    public partial class Form1 : Form
    {
        private List<ServerList>? serverList;
        private System.Timers.Timer updateTimer;

        public Form1()
        {
            InitializeComponent();

            serverListView.MouseClick += new MouseEventHandler(serverListView_MouseClick);
            serverListView.MouseDoubleClick += new MouseEventHandler(serverListView_MouseDoubleClick);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            updateTimer = new System.Timers.Timer();
            updateTimer.Elapsed += new ElapsedEventHandler(timedupdate);
            updateTimer.Interval = 1500;
            updateTimer.Enabled = true;
        }

        private void timedupdate(object source, ElapsedEventArgs e)
        {
            try
            {
                if (serverListView.InvokeRequired)
                    serverListView.Invoke(new MethodInvoker(() => Update()));
            }
            catch (ObjectDisposedException ex)
            {
            }
        }

        public async void Update()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://192.168.1.90:8000");
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage response = await client.GetAsync("/servers");
            if (response.IsSuccessStatusCode)
            {
                // Parse the response body.
                var responseData = await response.Content.ReadFromJsonAsync<List<ServerList>>();
                if (responseData == null)
                    return;

                foreach (var data in responseData)
                {
                    ListViewItem? foundItem = null;
                    for (int i = 0; i < serverListView.Items.Count; i++)
                    {
                        var item = serverListView.Items[i];
                        if (item == null)
                            continue;
                        if ((string)item.Tag == data.ip + ":" + data.port.ToString())
                        {
                            foundItem = item;
                            break;
                        }
                    }

                    if (foundItem == null)
                    {
                        string[] row = { "", data.name, data.players + "/" + data.max_players, "GTA3", data.gamemode };

                        var item = new ListViewItem(row);

                        item.Tag = data.ip + ":" + data.port.ToString();

                        if (!data.passworded)
                        {
                            item.ImageIndex = 0; // unlocked
                            item.SubItems[0].BackColor = Color.Green;
                        }
                        else
                        {
                            item.ImageIndex = 1; // locked
                            item.SubItems[0].BackColor = Color.Red;
                        }
                        
                        item.UseItemStyleForSubItems = false;

                        serverListView.Items.Add(item);
                    }
                    else
                    {
                        if (!data.passworded)
                        {
                            foundItem.ImageIndex = 0; // unlocked
                            foundItem.SubItems[0].BackColor = Color.Green;
                        }
                        else
                        {
                            foundItem.ImageIndex = 1; // locked
                            foundItem.SubItems[0].BackColor = Color.Red;
                        }

                        foundItem.SubItems[1].Text = data.name;
                        foundItem.SubItems[2].Text = data.players + "/" + data.max_players;
                        foundItem.SubItems[3].Text = "GTA3";
                        foundItem.SubItems[4].Text = data.gamemode;
                    }
                }

                foreach(ListViewItem item in serverListView.Items)
                {
                    if (responseData.Find(e => (e.ip + ":" + e.port.ToString()) == (string)item.Tag) == null)
                        serverListView.Items.Remove(item);
                }

                serverList = responseData;
            }
            else
            {
                // Console.WriteLine("{0} ({1})", (int)response.StatusCode, response.ReasonPhrase);
            }

            client.Dispose();
        }

        void serverListView_MouseClick(object? sender, MouseEventArgs e)
        {
            ListViewHitTestInfo info = serverListView.HitTest(e.X, e.Y);
            ListViewItem item = info.Item;

            if (item == null)
                return;

            ServerList? data = serverList?.Find(e => (e.ip + ":" + e.port.ToString()) == (string)item.Tag);
            if (data == null)
                return;

            playerListBox.Items.Clear();
            foreach(string? name in data.player_list)
            {
                playerListBox.Items.Add(name);
            }
        }

        void serverListView_MouseDoubleClick(object? sender, MouseEventArgs e)
        {
            ListViewHitTestInfo info = serverListView.HitTest(e.X, e.Y);
            ListViewItem item = info.Item;

            if (item == null)
                return;

            var data = ((string)info.Item.Tag).Split(":");

            Process process = new Process();
            process.StartInfo.FileName = "LauncherApplication.exe";
            process.StartInfo.Arguments = "-ip=\"" + data[0] + "\" -port=\"" + data[1] + "\" -game=\"1\"";
            try
            {
                process.Start();
                process.WaitForExit();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}