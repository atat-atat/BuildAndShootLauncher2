using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using Newtonsoft.Json.Linq;
using System.Collections;
using System.Net;

namespace BuildAndShootLauncher2
{
    public partial class mainForm : Form
    {
        public string game_path;
        //public bool launchedThroughProtocol;
        public mainForm()
        {
            if (!File.Exists("user.json"))
            {
                using (var client = new WebClient())
                {
                    client.DownloadFile("https://www.dropbox.com/s/auap7piqj0csi98/user.json?dl=0&raw=1", "user.json");
                }
            }

            string[] args = Environment.GetCommandLineArgs();

            if (args.Length > 1) //automatic server joiner
            {
                BuildAndShootLauncher2.Utilities utils = new BuildAndShootLauncher2.Utilities();
                utils.runSpades(args[1]);
                Application.Exit();
            }
            else
            {
                InitializeComponent();
            }

            Utilities util = new Utilities();
            var user_json = System.IO.File.ReadAllText("user.json");
            JObject user_info = JObject.Parse(System.IO.File.ReadAllText("user.json"));
            //if (!File.Exists("user.json"))
            //{
            //    File.Create("user.json");
            //    user_info["favorites"] = new JArray();
            //    user_info["last_sorted"] = 0;
            //    user_info["active_sorted"] = false;

            //    File.WriteAllText("user.json", user_info.ToString());
            //}

            if ((bool)user_info["use_bns"])
                usingBnSLLabel.Text = "(Using BnS Launcher)";
            else
                usingBnSLLabel.Text = "";

            game_path = util.getPath(false);

            if (!Directory.Exists(Directory.GetCurrentDirectory() + @"\versions") || !Directory.Exists(Directory.GetCurrentDirectory() + @"\versions\0.75"))
            {
                var versionSetupPopup = new versionsInstaller();
                versionSetupPopup.ShowDialog(this);
            }
            
            var MyIni = new MyProg.IniFile(game_path + @"\config.ini");

            string clientName = MyIni.Read("name", "client");

            welcomeLabel.Text = "Welcome back, " + clientName;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void quitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void connectButton_Click(object sender, EventArgs e)
        {
            var connectPopup = new directConnectPopup();
            connectPopup.ShowDialog(this);
        }

        private void buildAndShootLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ProcessStartInfo sInfo = new ProcessStartInfo("http://buildandshoot.com/play");
            Process.Start(sInfo);
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            var serverListPopup = new serverList();
            serverListPopup.ShowDialog(this);
        }

        private void setupButton_Click(object sender, EventArgs e)
        {
            var setupPopup = new setupPopup();
            setupPopup.ShowDialog(this);

            var user_json = System.IO.File.ReadAllText("user.json");
            JObject user_info = JObject.Parse(user_json);

            Utilities util = new Utilities();

            if ((bool)user_info["use_bns"])
                usingBnSLLabel.Text = "(Using BnS Launcher)";
            else
                usingBnSLLabel.Text = "";

            game_path = util.getPath((bool)user_info["use_bns"]);

            var MyIni = new MyProg.IniFile(game_path + @"\config.ini");

            string clientName = MyIni.Read("name", "client");

            welcomeLabel.Text = "Welcome back, " + clientName;
        }

        private void communityButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not ready yet!");
            //var communityPopup = new communityManager();
            //communityPopup.ShowDialog(this);
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
        }
    }
}
