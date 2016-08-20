using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json.Linq;
using System.Collections;

namespace BuildAndShootLauncher2
{
    public partial class setupPopup : Form
    {
        public string game_path;
        public bool usingBnS;
        public string DLLsel;
        public DataTable dt = new DataTable();
        public setupPopup()
        {
            InitializeComponent();

            resComboBox.SelectedIndex = 0;

            Utilities util = new Utilities();

            var user_json = System.IO.File.ReadAllText("user.json");
            JObject user_info = JObject.Parse(user_json);
            JArray injections = (JArray)user_info["injections"];
            JArray customVFolders = (JArray)user_info["custom_locations"];
            string confVer = (string)user_info["version"];

            if (confVer.StartsWith("c:"))
            {
                versionDataGrid.Rows[0].Selected = true;
            }

            if ((bool)user_info["use_bns"])
                checkBox1.Checked = true;

            game_path = util.getPath(user_info["use_bns"].ToObject<bool>());

            var MyIni = new MyProg.IniFile(game_path + @"\config.ini");

            string clientName = MyIni.Read("name", "client");
            string clientWindowed = MyIni.Read("windowed", "client");
            string clientMouseSens = MyIni.Read("mouse_sensitivity", "client");
            string clientVol = MyIni.Read("vol", "client");
            string clientInvertY = MyIni.Read("inverty", "client");
            string clientRes = MyIni.Read("xres", "client") + "x" + MyIni.Read("yres", "client");

            nameTextBox.Text = clientName;

            if (Convert.ToInt32(clientWindowed) == 1)
            {
                windowedCheckBox.Checked = true;
            }
            else
            {
                windowedCheckBox.Checked = false;
            }

            switch (clientRes)
            {
                case "640x480":
                    resComboBox.SelectedIndex = 0;
                    break;

                case "800x600":
                    resComboBox.SelectedIndex = 1;
                    break;

                case "1024x768":
                    resComboBox.SelectedIndex = 2;
                    break;

                case "1152x864":
                    resComboBox.SelectedIndex = 3;
                    break;

                case "1280x600":
                    resComboBox.SelectedIndex = 4;
                    break;

                case "1280x720":
                    resComboBox.SelectedIndex = 5;
                    break;

                case "1280x768":
                    resComboBox.SelectedIndex = 6;
                    break;

                case "1280x800":
                    resComboBox.SelectedIndex = 7;
                    break;

                case "1280x960":
                    resComboBox.SelectedIndex = 8;
                    break;

                default:
                    resComboBox.SelectedIndex = 9;

                    widthLabel.Visible = true;
                    widthTextBox.Visible = true;
                    widthTextBox.Text = MyIni.Read("xres", "client");

                    heightLabel.Visible = true;
                    heightTextBox.Visible = true;
                    heightTextBox.Text = MyIni.Read("yres", "client");
                    break;
            }

            var mouse_sens = Convert.ToDecimal(clientMouseSens);
            mouseSensTrackBar.Value = (int)mouse_sens;

            volumeTrackBar.Value = Convert.ToInt32(clientVol);
            if (Convert.ToInt32(clientInvertY) == 1)
            {
                invertCheckBox.Checked = true;
            }
            else
            {
                invertCheckBox.Checked = false;
            }

            volumeValueLabel.Text = volumeTrackBar.Value.ToString();
            mouseSensValueLabel.Text = mouseSensTrackBar.Value.ToString();

            dt.Columns.Add(new DataColumn("File Name", typeof(string)));
            dt.Columns.Add(new DataColumn("Location", typeof(string)));

            if (File.Exists(game_path + @"\dll\pubovl.dll"))
                dt.Rows.Add("pubovl.dll", (game_path + @"\dll\pubovl.dll").Replace(@"\", "/"));

            foreach (var injection in injections)
            {
                dt.Rows.Add(Path.GetFileName((string)injection), injection.ToString());
            }

            injectDataGrid.DataSource = dt;

            DataTable vt = new DataTable();
            vt.Columns.Add("Version", typeof(string));
            vt.Columns.Add("Location", typeof(string));

            string[] versionFolders = Directory.GetDirectories("versions");

            foreach (string version in versionFolders)
            {
                vt.Rows.Add(Path.GetFileName(version), version);
            }

            foreach (string cVer in customVFolders)
            {
                vt.Rows.Add(cVer, cVer);
            }

            versionDataGrid.DataSource = vt;
        }

        private void cancelChangesButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void resComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (resComboBox.SelectedIndex == 9)
            {
                widthLabel.Visible = true;
                widthTextBox.Visible = true;
                heightLabel.Visible = true;
                heightTextBox.Visible = true;
            }
        }

        private void volumeTrackBar_ValueChanged(object sender, EventArgs e)
        {
            volumeValueLabel.Text = volumeTrackBar.Value.ToString();
        }

        private void mouseSensTrackBar_ValueChanged(object sender, EventArgs e)
        {
            mouseSensValueLabel.Text = mouseSensTrackBar.Value.ToString();
        }

        private void saveChangesButton_Click(object sender, EventArgs e)
        {
            var MyIni = new MyProg.IniFile(game_path + @"\config.ini");
            MyIni.Write("name", " " + nameTextBox.Text, "client");
            MyIni.Write("vol", " " + volumeTrackBar.Value.ToString(), "client");

            if (invertCheckBox.Checked)
                MyIni.Write("inverty", " 1", "client");
            else
                MyIni.Write("inverty", " 0", "client");

            if (windowedCheckBox.Checked)
                MyIni.Write("windowed", " 1", "client");
            else
                MyIni.Write("windowed", " 0", "client");

            MyIni.Write("mouse_sensitivity", " " + mouseSensTrackBar.Value.ToString(), "client");

            switch (resComboBox.SelectedIndex)
            {
                case 0:
                    MyIni.Write("xres", " 640", "client");
                    MyIni.Write("yres", " 480", "client");
                    break;
                case 1:
                    MyIni.Write("xres", " 800", "client");
                    MyIni.Write("yres", " 600", "client");
                    break;
                case 2:
                    MyIni.Write("xres", " 1024", "client");
                    MyIni.Write("yres", " 768", "client");
                    break;
                case 3:
                    MyIni.Write("xres", " 1152", "client");
                    MyIni.Write("yres", " 864", "client");
                    break;
                case 4:
                    MyIni.Write("xres", " 1280", "client");
                    MyIni.Write("yres", " 600", "client");
                    break;
                case 5:
                    MyIni.Write("xres", " 1280", "client");
                    MyIni.Write("yres", " 720", "client");
                    break;
                case 6:
                    MyIni.Write("xres", " 1280", "client");
                    MyIni.Write("yres", " 768", "client");
                    break;
                case 7:
                    MyIni.Write("xres", " 1280", "client");
                    MyIni.Write("yres", " 800", "client");
                    break;
                case 8:
                    MyIni.Write("xres", " 1280", "client");
                    MyIni.Write("yres", " 960", "client");
                    break;
                case 9:
                    if (widthTextBox.Text != "")
                        MyIni.Write("xres", " " + widthTextBox.Text, "client");
                        MyIni.Write("yres", " " + heightTextBox.Text, "client");
                    break;
            }

            var user_json = System.IO.File.ReadAllText("user.json");
            JObject user_info = JObject.Parse(user_json);

            user_info["use_bns"] = usingBnS;
            File.WriteAllText("user.json", user_info.ToString());

            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                usingBnS = true;
            else
                usingBnS = false;
        }

        private void addDLLButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.Filter = "Dynamic Link Libraries (*.dll)|*.dll";
            openFileDialog1.FilterIndex = 1;

            //openFileDialog1.Multiselect = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                var user_json = System.IO.File.ReadAllText("user.json");
                JObject user_info = JObject.Parse(user_json);
                JArray injections = (JArray)user_info["injections"];

                int pos = Array.IndexOf(injections.ToObject<string[]>(), (openFileDialog1.InitialDirectory + openFileDialog1.FileName).Replace(@"\", "/"));
                if (pos != -1)
                {
                    MessageBox.Show("That DLL has already been added.");
                    return;
                }

                injections.Add((openFileDialog1.InitialDirectory + openFileDialog1.FileName).Replace(@"\", "/"));

                File.WriteAllText("user.json", user_info.ToString());

                dt.Rows.Add(Path.GetFileNameWithoutExtension(openFileDialog1.InitialDirectory + openFileDialog1.FileName), (openFileDialog1.InitialDirectory + openFileDialog1.FileName).Replace(@"\", "/"));
            }
        }

        private void injectDataGrid_SelectionChanged(object sender, EventArgs e)
        {
            if (injectDataGrid.SelectedCells.Count > 0)
            {
                int selectedrowindex = injectDataGrid.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = injectDataGrid.Rows[selectedrowindex];
                DLLsel = Convert.ToString(selectedRow.Cells["Location"].Value);
                if (DLLsel.Replace("/", @"\") == game_path + @"\dll\pubovl.dll")
                    removeDLLButton.Enabled = false;
                else
                    removeDLLButton.Enabled = true;
            }
        }

        private void removeDLLButton_Click(object sender, EventArgs e)
        {
            //var confirmResult = MessageBox.Show("Are you sure you want to delete that DLL?\n(Doing so means that not only will the DLL be removed from this list, but the actual file will be removed as well.)",
            //"Confirmation",
            //MessageBoxButtons.YesNo);
            var user_json = System.IO.File.ReadAllText("user.json");
            JObject user_info = JObject.Parse(user_json);
            JArray injections = (JArray)user_info["injections"];

            int pos = Array.IndexOf(injections.ToObject<string[]>(), DLLsel);

            if (pos != -1)
            {
                injections.RemoveAt(pos);
                File.WriteAllText("user.json", user_info.ToString());
            }

            var toBeRemoved = new ArrayList();
            foreach (DataRow row in dt.Rows)
            {
                if (row["Location"].ToString() == DLLsel)
                {
                    toBeRemoved.Add(row);
                    break;
                }
            }

            foreach (DataRow row in toBeRemoved)
            {
                dt.Rows.Remove(row);
            }
            
        }

        private void addInstallButton_Click(object sender, EventArgs e)
        {
            var addVersionPopup = new addNewVersionPopup();
            addVersionPopup.ShowDialog(this);

            var user_json = System.IO.File.ReadAllText("user.json");
            JObject user_info = JObject.Parse(user_json);
            JArray customVFolders = (JArray)user_info["custom_locations"];

            DataTable vt = new DataTable();
            vt.Columns.Add("Version", typeof(string));
            vt.Columns.Add("Location", typeof(string));

            string[] versionFolders = Directory.GetDirectories("versions");

            foreach (string version in versionFolders)
            {
                vt.Rows.Add(Path.GetFileName(version), version);
            }

            foreach (string cVer in customVFolders)
            {
                vt.Rows.Add(cVer.Replace("/", @"\"), cVer.Replace("/", @"\"));
            }

            versionDataGrid.DataSource = vt;
        }

        private void versionDataGrid_SelectionChanged(object sender, EventArgs e)
        {

            if (versionDataGrid.SelectedCells.Count > 0)
            {
                int selectedrowindex = versionDataGrid.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = versionDataGrid.Rows[selectedrowindex];

                var user_json = System.IO.File.ReadAllText("user.json");
                JObject user_info = JObject.Parse(user_json);
                string version = (string)user_info["version"];
                //MessageBox.Show(version);

                version = (Convert.ToString(selectedRow.Cells["Location"].Value)).Replace(@"\", "/");
                //MessageBox.Show(version);
                //File.WriteAllText("user.json", user_info.ToString());
            }
            
        }
    }
}
