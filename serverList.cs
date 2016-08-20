using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using System.Net;
using System.IO;
using System.Diagnostics;

namespace BuildAndShootLauncher2
{
    public partial class serverList : Form
    {
        public string identifier;
        public string mod_path;
        public string game_path;
        public bool inFavorites;
        public bool injectPubovl;
        public dynamic cachedServers = new ArrayList();
        public DataTable dt = new DataTable();
        public serverList()
        {
            InitializeComponent();

            lastRefreshLabel.Text = "";

            Utilities util = new Utilities();

            var user_json = System.IO.File.ReadAllText("user.json");
            JObject user_info = JObject.Parse(user_json);

            game_path = util.getPath((bool)user_info["use_bns"]);

            dt.Columns.Add(new DataColumn("Name", typeof(string)));
            dt.Columns.Add(new DataColumn("Players", typeof(int)));
            dt.Columns.Add(new DataColumn("Max.Players", typeof(int)));
            dt.Columns.Add(new DataColumn("Game Mode", typeof(string)));
            dt.Columns.Add(new DataColumn("Country", typeof(string)));
            dt.Columns.Add(new DataColumn("Latency", typeof(int)));
            dt.Columns.Add(new DataColumn("Identifier", typeof(string)));
            string json = "";
            bool success = true;
            try
            {
                json = new WebClient().DownloadString("http://services.buildandshoot.com/serverlist.json");
            }
            catch (System.Net.WebException)
            {
                MessageBox.Show("Failed to connect to the Build and Shoot serverlist.", "Error");
                success = false;
                Application.Exit();
            }

            if (success == false)
            {
                Application.Exit();
            }
            
            JArray server1 = JArray.Parse(json);
            JArray favorites = (JArray)user_info["favorites"];

            int activePlayers = 0;
            int servers = 0;
            if (Convert.ToInt32(user_info["last_sorted"]) == 1)
            {
                inFavorites = true;
            }
            foreach (var server in server1)
            {
                if (Convert.ToInt32(user_info["last_sorted"]) == 0)
                {
                    dt.Rows.Add(server["name"], server["players_current"], server["players_max"], server["game_mode"], server["country"], server["latency"], server["identifier"]);
                }
                else
                {
                    if (util.ItemExists(favorites.ToObject<string[]>(), server["identifier"].ToString()))
                    {
                        dt.Rows.Add(server["name"], server["players_current"], server["players_max"], server["game_mode"], server["country"], server["latency"], server["identifier"]);
                    }
                }
                    

                activePlayers += server["players_current"].ToObject<int>();
                servers += 1;
            }
            playersOnline.Text = "Players Online: " + activePlayers.ToString(); //display how many players are online
            serverCount.Text = "Servers: " + servers.ToString(); //display how many servers are available

            serverListDataGrid.DataSource = dt;
            //Set widths for each column
            serverListDataGrid.Columns[0].Width = 120;
            serverListDataGrid.Columns[1].Width = 68;
            serverListDataGrid.Columns[2].Width = 68;
            serverListDataGrid.Columns[3].Width = 68;
            serverListDataGrid.Columns[4].Width = 64;
            serverListDataGrid.Columns[5].Width = 68;
            this.serverListDataGrid.Sort(this.serverListDataGrid.Columns["Players"], ListSortDirection.Descending);

            mod_path = game_path + @"\modloader\settings.ini";

            //var path = Directory.GetCurrentDirectory() + @"\versions\0.75\modloader\settings.ini";
            var modSettings = new MyProg.IniFile(mod_path);

            selectedModLabel.Text = "Selected Mod: " + modSettings.Read("active_mod");
            if (user_info["active_sorted"].ToObject<bool>())
            {
                checkBox1.Checked = true;
                var itemsToRemove = new ArrayList();
                foreach (DataRow row in dt.Rows)
                {
                    if (Convert.ToInt32(row["Players"]) == 0)
                        itemsToRemove.Add(row);
                }

                foreach (DataRow row in itemsToRemove)
                {
                    dt.Rows.Remove(row);
                }
            }
        }

        private void serverListDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void serverList_MouseClick(object sender, MouseEventArgs e)
        {
            //whatever goes here idk
        }

        private void serverList_Click(object sender, EventArgs e)
        {

        }

        private void serverListDataGrid_Click(object sender, EventArgs e)
        {

        }

        private void serverListDataGrid_SelectionChanged(object sender, EventArgs e)
        {
            if (serverListDataGrid.SelectedCells.Count > 0)
            {
                int selectedrowindex = serverListDataGrid.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = serverListDataGrid.Rows[selectedrowindex];
                identifier = Convert.ToString(selectedRow.Cells["Identifier"].Value);

                var json = System.IO.File.ReadAllText("user.json");
                JObject user_info = JObject.Parse(json);
                JArray favorites = (JArray)user_info["favorites"];
                int pos = Array.IndexOf(favorites.ToObject<string[]>(), identifier);
                if (pos > -1)
                {
                    addFavoritesButton.Text = "Remove from Favorites";
                }
                else
                {
                    addFavoritesButton.Text = "Add to Favorites";
                }

            }
        }

        private void connectToServerButton_Click(object sender, EventArgs e)
        {
            BuildAndShootLauncher2.Utilities utils = new BuildAndShootLauncher2.Utilities();
            utils.runSpades(identifier);
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(inFavorites.ToString());
            var json = new WebClient().DownloadString("http://services.buildandshoot.com/serverlist.json");
            JArray server1 = JArray.Parse(json);

            var user_json = System.IO.File.ReadAllText("user.json");
            JObject user_info = JObject.Parse(user_json);
            JArray favorites = (JArray)user_info["favorites"];

            dt.Clear();

            int activePlayers = 0;
            int servers = 0;
            Utilities util = new Utilities();
            foreach (var server in server1)
            {
                if (checkBox1.Checked && !inFavorites)
                {
                    if (server["players_current"].ToObject<int>() > 0)
                        dt.Rows.Add(server["name"], server["players_current"], server["players_max"], server["game_mode"], server["country"], server["latency"], server["identifier"]);
                }
                else if (inFavorites && !checkBox1.Checked)
                {
                    if (util.ItemExists(favorites.ToObject<string[]>(), server["identifier"].ToString()))
                        dt.Rows.Add(server["name"], server["players_current"], server["players_max"], server["game_mode"], server["country"], server["latency"], server["identifier"]);
                }
                else if (inFavorites && checkBox1.Checked)
                {
                    if (server["players_current"].ToObject<int>() > 0 && util.ItemExists(favorites.ToObject<string[]>(), server["identifier"].ToString()))
                        dt.Rows.Add(server["name"], server["players_current"], server["players_max"], server["game_mode"], server["country"], server["latency"], server["identifier"]);
                }
                else
                {
                    dt.Rows.Add(server["name"], server["players_current"], server["players_max"], server["game_mode"], server["country"], server["latency"], server["identifier"]);
                }
                //dt.Rows.Add(server["name"], server["players_current"], server["players_max"], server["game_mode"], server["country"], server["latency"], server["identifier"]);

                activePlayers += server["players_current"].ToObject<int>();
                servers += 1;
            }
            playersOnline.Text = "Players Online: " + activePlayers.ToString();
            serverCount.Text = "Servers: " + servers.ToString();
            lastRefreshLabel.Text = "(" + DateTime.Now.ToString("h:mm:ss") + ")";
        }

        private void changeModsButton_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(Directory.GetCurrentDirectory() + @"\versions\0.75\modloader") && !Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\Build and Shoot\Game Installations\0.75\modloader"))
            {
                MessageBox.Show("Neither your Build and Shoot game installation, or your versions folder has learn_more's Modloader installed, or the modloader folder is missing.");
            }
            else
            {
                var modsPopup = new changeModsPopup();
                modsPopup.ShowDialog(this);
                var modSettings = new MyProg.IniFile(mod_path);

                selectedModLabel.Text = "Selected Mod: " + modSettings.Read("active_mod");
            }
            
        }

        private void addFavoritesButton_Click(object sender, EventArgs e)
        {
            var json = System.IO.File.ReadAllText("user.json");
            JObject user_info = JObject.Parse(json);
            JArray favorites = (JArray)user_info["favorites"];
            int pos = Array.IndexOf(favorites.ToObject<string[]>(), identifier);
            if (pos <= -1)
            {
                favorites.Add(identifier);
                File.WriteAllText("user.json", user_info.ToString());
                addFavoritesButton.Text = "Remove from Favorites";
            }
            else
            {
                favorites.RemoveAt(pos);
                File.WriteAllText("user.json", user_info.ToString());
                addFavoritesButton.Text = "Add to Favorites";
            }
        }

        private void viewFavoritesButton_Click(object sender, EventArgs e)
        {
            //if (inFavorites)
            //{
            //    inFavorites = false;
            //}
            //else
            //{
            if (!inFavorites)
            {
                inFavorites = true;
                //}
                Utilities util = new Utilities();
                var json = new WebClient().DownloadString("http://services.buildandshoot.com/serverlist.json");
                JArray server1 = JArray.Parse(json);

                var user_json = System.IO.File.ReadAllText("user.json");
                JObject user_info = JObject.Parse(user_json);
                JArray favorites = (JArray)user_info["favorites"];
                user_info["last_sorted"] = 1;
                File.WriteAllText("user.json", user_info.ToString());

                dt.Clear();
                foreach (var server in server1)
                {
                    if (!checkBox1.Checked)
                    {
                        if (util.ItemExists(favorites.ToObject<string[]>(), server["identifier"].ToString()))
                            dt.Rows.Add(server["name"], server["players_current"], server["players_max"], server["game_mode"], server["country"], server["latency"], server["identifier"]);
                    }

                    else
                    {
                        if (server["players_current"].ToObject<int>() > 0 && util.ItemExists(favorites.ToObject<string[]>(), server["identifier"].ToString()))
                            dt.Rows.Add(server["name"], server["players_current"], server["players_max"], server["game_mode"], server["country"], server["latency"], server["identifier"]);
                    }
                            

                }
            }
            
        }

        private void serverSearch_TextChanged(object sender, EventArgs e)
        {
            var itemsToRemove = new ArrayList();

            foreach (DataRow row in dt.Rows)
            {
                if (!row["Name"].ToString().Contains(serverSearch.Text))
                {
                    itemsToRemove.Add(row);
                }
            }

            foreach (DataRow row in itemsToRemove)
            {
                cachedServers.Add(row);
                dt.Rows.Remove(row);
            }


        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            var itemsToRemove = new ArrayList();
            var user_json = System.IO.File.ReadAllText("user.json");
            JObject user_info = JObject.Parse(user_json);
            JArray favorites = (JArray)user_info["favorites"];

            Utilities util = new Utilities();

            foreach (DataRow row in dt.Rows)
            {
                if (Convert.ToInt32(row["Players"]) == 0)
                    itemsToRemove.Add(row);
            }

            if (checkBox1.Checked)
            {
                foreach (DataRow row in itemsToRemove)
                {
                    dt.Rows.Remove(row);
                }

                user_info["active_sorted"] = true;
                File.WriteAllText("user.json", user_info.ToString());
            }
            else
            {
                dt.Rows.Clear();
                var json = new WebClient().DownloadString("http://services.buildandshoot.com/serverlist.json");
                JArray server1 = JArray.Parse(json);
                foreach (var server in server1)
                {
                    if (inFavorites)
                    {
                        if (util.ItemExists(favorites.ToObject<string[]>(), server["identifier"].ToString()))
                            dt.Rows.Add(server["name"], server["players_current"], server["players_max"], server["game_mode"], server["country"], server["latency"], server["identifier"]);
                    }
                    else
                    {
                        dt.Rows.Add(server["name"], server["players_current"], server["players_max"], server["game_mode"], server["country"], server["latency"], server["identifier"]);
                    }
                }
                user_info["active_sorted"] = false;
                File.WriteAllText("user.json", user_info.ToString());


                //    var json = new WebClient().DownloadString("http://services.buildandshoot.com/serverlist.json");
                //    JArray server1 = JArray.Parse(json);
                //   foreach (var server in server1)
                //   {
                //       dt.Rows.Add(server["name"], server["players_current"], server/["players_max"], server["game_mode"], server["country"], server["latency"], server["identifier"]);
                //}
            }
        }

        private void viewAllButton_Click(object sender, EventArgs e)
        {
            inFavorites = false;
            var user_json = System.IO.File.ReadAllText("user.json");
            JObject user_info = JObject.Parse(user_json);
            user_info["last_sorted"] = 0;
            File.WriteAllText("user.json", user_info.ToString());

            dt.Rows.Clear();
            var json = new WebClient().DownloadString("http://services.buildandshoot.com/serverlist.json");
            JArray server1 = JArray.Parse(json);
            foreach (var server in server1)
            {
                if (!checkBox1.Checked)
                    dt.Rows.Add(server["name"], server["players_current"], server["players_max"], server["game_mode"], server["country"], server["latency"], server["identifier"]);
                else
                    if (Convert.ToInt32(server["players_current"]) > 0)
                        dt.Rows.Add(server["name"], server["players_current"], server["players_max"], server["game_mode"], server["country"], server["latency"], server["identifier"]);
            }
        }

        private void localHostButton_Click(object sender, EventArgs e)
        {
            Utilities util = new Utilities();
            util.runSpades("aos://16777343");
        }

        private void serverList_Load(object sender, EventArgs e)
        {

        }

        private void changeGameSett_Click(object sender, EventArgs e)
        {
            var setupPopup = new setupPopup();
            setupPopup.ShowDialog(this);
        }

        private void injectPubovlCheck_CheckedChanged(object sender, EventArgs e)
        {

            var user_json = System.IO.File.ReadAllText("user.json");
            JObject user_info = JObject.Parse(user_json);

            user_info["inject_pubovl"] = injectPubovl;

            File.WriteAllText("user.json", user_info.ToString());
        }

        private void serverListDataGrid_DoubleClick(object sender, EventArgs e)
        {
            if (serverListDataGrid.SelectedCells.Count > 0)
            {
                int selectedrowindex = serverListDataGrid.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = serverListDataGrid.Rows[selectedrowindex];
                identifier = Convert.ToString(selectedRow.Cells["Identifier"].Value);

                var json = System.IO.File.ReadAllText("user.json");
                JObject user_info = JObject.Parse(json);
                JArray favorites = (JArray)user_info["favorites"];
                int pos = Array.IndexOf(favorites.ToObject<string[]>(), identifier);
                if (pos > -1)
                {
                    addFavoritesButton.Text = "Remove from Favorites";
                }
                else
                {
                    addFavoritesButton.Text = "Add to Favorites";
                }

            }
            Utilities util = new Utilities();
            util.runSpades(identifier, injectPubovl);
        }

        private void injectAllButton_Click(object sender, EventArgs e)
        {
            Utilities util = new Utilities();
            var user_json = System.IO.File.ReadAllText("user.json");
            JObject user_info = JObject.Parse(System.IO.File.ReadAllText("user.json"));
            bool usingBnS = (bool)user_info["use_bns"];

            List<string> toInject = new List<string>();

            toInject.Add(util.getPath(usingBnS) + @"\dll\pubovl.dll");

            foreach (string dll in (JArray)user_info["injections"])
            {
                toInject.Add(dll.Replace("/", @"\"));
            } 

            Injector injector = new Injector();
            String strProcessName = "client";
            Process[] pname = Process.GetProcessesByName("client");
            if (pname.Length == 0)
            {
                MessageBox.Show("Please open Ace of Spades before injecting anything.");
                return;
            }
                

            Int32 ProcID = injector.GetProcessId(strProcessName);
            if (ProcID >= 0)
            {
                IntPtr hProcess = (IntPtr)Injector.OpenProcess(0x1F0FFF, 1, ProcID);
                if (hProcess == null)
                {
                    MessageBox.Show("OpenProcess() Failed!");
                    return;
                }
                else
                    foreach (string i in toInject)
                    {
                        injector.InjectDLL(hProcess, i);
                    }
                    
            }
        }

        private void injectPubovlButton_Click(object sender, EventArgs e)
        {
            Utilities util = new Utilities();
            var user_json = System.IO.File.ReadAllText("user.json");
            JObject user_info = JObject.Parse(System.IO.File.ReadAllText("user.json"));
            bool usingBnS = (bool)user_info["use_bns"];

            String pubovlDLL = util.getPath(usingBnS) + @"\dll\pubovl.dll";

            Injector injector = new Injector();
            String strProcessName = "client";
            Process[] pname = Process.GetProcessesByName("client");
            if (pname.Length == 0)
            {
                MessageBox.Show("Please open Ace of Spades before injecting anything.");
                return;
            }


            Int32 ProcID = injector.GetProcessId(strProcessName);
            if (ProcID >= 0)
            {
                IntPtr hProcess = (IntPtr)Injector.OpenProcess(0x1F0FFF, 1, ProcID);
                if (hProcess == null)
                {
                    MessageBox.Show("OpenProcess() Failed!");
                    return;
                }
                else
                    injector.InjectDLL(hProcess, pubovlDLL);

            }
        }

        private void injectCustomsButton_Click(object sender, EventArgs e)
        {
            Utilities util = new Utilities();
            var user_json = System.IO.File.ReadAllText("user.json");
            JObject user_info = JObject.Parse(System.IO.File.ReadAllText("user.json"));
            bool usingBnS = (bool)user_info["use_bns"];

            List<string> toInject = new List<string>();

            foreach (string dll in (JArray)user_info["injections"])
            {
                toInject.Add(dll.Replace("/", @"\"));
            }

            Injector injector = new Injector();
            String strProcessName = "client";
            Process[] pname = Process.GetProcessesByName("client");
            if (pname.Length == 0)
            {
                MessageBox.Show("Please open Ace of Spades before injecting anything.");
                return;
            }


            Int32 ProcID = injector.GetProcessId(strProcessName);
            if (ProcID >= 0)
            {
                IntPtr hProcess = (IntPtr)Injector.OpenProcess(0x1F0FFF, 1, ProcID);
                if (hProcess == null)
                {
                    MessageBox.Show("OpenProcess() Failed!");
                    return;
                }
                else
                    foreach (string i in toInject)
                    {
                        injector.InjectDLL(hProcess, i);
                    }

            }
        }
    }
}
