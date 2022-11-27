namespace ServerBrowserApplication
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.playerListBox = new System.Windows.Forms.ListBox();
            this.icons = new System.Windows.Forms.ImageList(this.components);
            this.tabInternetPage = new System.Windows.Forms.TabPage();
            this.serverListView = new System.Windows.Forms.ListView();
            this.serverListColLocked = new System.Windows.Forms.ColumnHeader();
            this.serverListColHostname = new System.Windows.Forms.ColumnHeader();
            this.serverListColPlayers = new System.Windows.Forms.ColumnHeader();
            this.serverListColGamemode = new System.Windows.Forms.ColumnHeader();
            this.serverListColGame = new System.Windows.Forms.ColumnHeader();
            this.browserTabs = new System.Windows.Forms.TabControl();
            this.groupBox1.SuspendLayout();
            this.tabInternetPage.SuspendLayout();
            this.browserTabs.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.playerListBox);
            this.groupBox1.Location = new System.Drawing.Point(582, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(206, 395);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Players";
            // 
            // playerListBox
            // 
            this.playerListBox.FormattingEnabled = true;
            this.playerListBox.ItemHeight = 15;
            this.playerListBox.Location = new System.Drawing.Point(6, 22);
            this.playerListBox.Name = "playerListBox";
            this.playerListBox.Size = new System.Drawing.Size(194, 364);
            this.playerListBox.TabIndex = 1;
            // 
            // icons
            // 
            this.icons.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.icons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("icons.ImageStream")));
            this.icons.TransparentColor = System.Drawing.Color.Transparent;
            this.icons.Images.SetKeyName(0, "unlock.png");
            this.icons.Images.SetKeyName(1, "lock.png");
            // 
            // tabInternetPage
            // 
            this.tabInternetPage.Controls.Add(this.serverListView);
            this.tabInternetPage.Location = new System.Drawing.Point(4, 24);
            this.tabInternetPage.Name = "tabInternetPage";
            this.tabInternetPage.Padding = new System.Windows.Forms.Padding(3);
            this.tabInternetPage.Size = new System.Drawing.Size(559, 367);
            this.tabInternetPage.TabIndex = 1;
            this.tabInternetPage.Text = "Internet";
            this.tabInternetPage.UseVisualStyleBackColor = true;
            // 
            // serverListView
            // 
            this.serverListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.serverListColLocked,
            this.serverListColHostname,
            this.serverListColPlayers,
            this.serverListColGame,
            this.serverListColGamemode});
            this.serverListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.serverListView.FullRowSelect = true;
            this.serverListView.Location = new System.Drawing.Point(3, 3);
            this.serverListView.Name = "serverListView";
            this.serverListView.Size = new System.Drawing.Size(553, 361);
            this.serverListView.SmallImageList = this.icons;
            this.serverListView.TabIndex = 0;
            this.serverListView.UseCompatibleStateImageBehavior = false;
            this.serverListView.View = System.Windows.Forms.View.Details;
            // 
            // serverListColLocked
            // 
            this.serverListColLocked.Text = "";
            this.serverListColLocked.Width = 30;
            // 
            // serverListColHostname
            // 
            this.serverListColHostname.Text = "Hostname";
            this.serverListColHostname.Width = 295;
            // 
            // serverListColPlayers
            // 
            this.serverListColPlayers.Text = "Players";
            // 
            // serverListColGamemode
            // 
            this.serverListColGamemode.Text = "Gamemode";
            this.serverListColGamemode.Width = 100;
            // 
            // serverListColGame
            // 
            this.serverListColGame.Text = "Game";
            // 
            // browserTabs
            // 
            this.browserTabs.Controls.Add(this.tabInternetPage);
            this.browserTabs.Location = new System.Drawing.Point(9, 6);
            this.browserTabs.Name = "browserTabs";
            this.browserTabs.SelectedIndex = 0;
            this.browserTabs.Size = new System.Drawing.Size(567, 395);
            this.browserTabs.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 406);
            this.Controls.Add(this.browserTabs);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Liberty City Multiplayer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.tabInternetPage.ResumeLayout(false);
            this.browserTabs.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private ListBox playerListBox;
        private ImageList icons;
        private TabPage tabInternetPage;
        private ListView serverListView;
        private ColumnHeader serverListColLocked;
        private ColumnHeader serverListColHostname;
        private ColumnHeader serverListColPlayers;
        private TabControl browserTabs;
        private ColumnHeader serverListColGamemode;
        private ColumnHeader serverListColGame;
    }
}