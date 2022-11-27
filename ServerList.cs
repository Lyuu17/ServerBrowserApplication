using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerBrowserApplication
{
    internal class ServerList
    {
        public string ip { get; set; }
        public int port { get; set; }
        public string name { get; set; }
        public int players { get; set; }
        public int max_players { get; set; }
        public bool passworded { get; set; }
        public string gamemode { get; set; }
        public int game { get; set; }
        public string[] player_list { get; set; }
        public long timeout { get; set; }
    }
}
