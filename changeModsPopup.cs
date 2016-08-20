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
using System.IO.Compression;
using Newtonsoft.Json.Linq;
using System.Collections;

namespace BuildAndShootLauncher2
{
    public partial class changeModsPopup : Form
    {
        public string modSel;
        public string modLPath;
        public DataTable dt = new DataTable();
        public changeModsPopup()
        {
            InitializeComponent();

            Utilities util = new Utilities();
            var user_json = System.IO.File.ReadAllText("user.json");
            JObject user_info = JObject.Parse(user_json);
            modLPath = util.getPath((bool)user_info["use_bns"]) + @"\modloader";
                
            var directories = Directory.GetDirectories(modLPath);

            dt.Columns.Add(new DataColumn("Name", typeof(string)));
            dt.Columns.Add(new DataColumn("Author", typeof(string)));
            dt.Columns.Add(new DataColumn("Version", typeof(string)));
            dt.Columns.Add(new DataColumn("Directory", typeof(string)));
            //dt.Rows.Add();

            foreach (string directory in directories)
            {
                if (File.Exists(directory + @"\info.json"))
                {
                    var json = System.IO.File.ReadAllText(directory + @"\info.json");
                    JObject mod_info = JObject.Parse(json);
                    //JArray mod_info = JArray.Parse(json);
                    dt.Rows.Add(mod_info["name"], mod_info["author"], mod_info["version"], directory);
                }
                else
                {
                    dt.Rows.Add(Path.GetFileName(directory), "N/A", "0.0", directory);
                }
                
            }

            modsDataGrid.DataSource = dt;
            this.modsDataGrid.Sort(this.modsDataGrid.Columns["Name"], ListSortDirection.Ascending);

        }

        private void changeModsPopup_Load(object sender, EventArgs e)
        {

        }

        private void modsDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void mmCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void modsDataGrid_SelectionChanged(object sender, EventArgs e)
        {
            if (modsDataGrid.SelectedCells.Count > 0)
            {
                int selectedrowindex = modsDataGrid.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = modsDataGrid.Rows[selectedrowindex];

                modSel = Path.GetFileName(Convert.ToString(selectedRow.Cells["Directory"].Value));

                if (File.Exists(Convert.ToString(selectedRow.Cells["Directory"].Value) + @"\cover.png"))
                {
                    modCover.Image = Image.FromFile(Convert.ToString(selectedRow.Cells["Directory"].Value) + @"\cover.png");
                }
                else
                {
                    var path = Directory.GetCurrentDirectory();
                    modCover.Image = BuildAndShootLauncher2.Properties.Resources.no_mod_cover;
                }

                modAuthor.Text = "Author: " + Convert.ToString(selectedRow.Cells["Author"].Value);
                modVersion.Text = "Version: " +  Convert.ToString(selectedRow.Cells["Version"].Value);

                if (File.Exists(Convert.ToString(selectedRow.Cells["Directory"].Value) + @"\info.json"))
                {
                    var json = System.IO.File.ReadAllText(Convert.ToString(selectedRow.Cells["Directory"].Value) + @"\info.json");
                    JObject mod_info = JObject.Parse(json);
                    modDescription.Text = "Description: " + (string)mod_info["description"];
                    modWebsite.Links.Clear();
                    modWebsite.Links.Add(0, modWebsite.Text.Length, (string)mod_info["website"]);
                    modWebsite.Text = "Website";
                }
                else
                {
                    modDescription.Text =  "Description: N/A";
                    modWebsite.Links.Clear();
                    modWebsite.Text = "No Website";
                }
                
                //identifier = Convert.ToString(selectedRow.Cells["Identifier"].Value);
                //pictureBox1.Image = Image.FromFile(@"Images\a.bmp");
            }
        }

        private void mmDone_Click(object sender, EventArgs e)
        {
            //var modSettings = new MyProg.IniFile(modLPath = @"\settings.ini");
            string fileName = modLPath + @"\settings.ini";
            var tempFile = Path.GetTempFileName();
            var linesToKeep = File.ReadLines(fileName).Where(l => !l.StartsWith("active_mod"));

            File.WriteAllLines(tempFile, linesToKeep);
            File.AppendAllText(tempFile, "active_mod = " + modSel);

            File.Delete(fileName);
            File.Move(tempFile, fileName);
            //modSettings.Write("active_mod", modSel, "ModLoader");
            this.Close();
        }

        private void addModButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.Filter = "Zip Archive (*.zip)|*.zip";
            openFileDialog1.FilterIndex = 1;

            openFileDialog1.Multiselect = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //string path = openFileDialog1.InitialDirectory + openFileDialog1.FileName;
                string zipPath = openFileDialog1.InitialDirectory + openFileDialog1.FileName;

                string extractPath = Directory.GetCurrentDirectory() + @"\versions\0.75\modloader\" + Path.GetFileNameWithoutExtension(openFileDialog1.FileName);

                if (!File.Exists(extractPath))
                {
                    Directory.CreateDirectory(extractPath);
                }
                

                using (ZipArchive archive = ZipFile.OpenRead(zipPath))
                {
                    foreach (ZipArchiveEntry entry in archive.Entries)
                    {
                        //if (entry.FullName.EndsWith(".txt", StringComparison.OrdinalIgnoreCase))
                        //{

                        entry.ExtractToFile(Path.Combine(extractPath, entry.FullName));
                        //}
                    }
                }

                dt.Clear();
                var directories = Directory.GetDirectories(modLPath);

                foreach (string directory in directories)
                {
                    if (File.Exists(directory + @"\info.json"))
                    {
                        var json = System.IO.File.ReadAllText(directory + @"\info.json");
                        JObject mod_info = JObject.Parse(json);
                        //JArray mod_info = JArray.Parse(json);
                        dt.Rows.Add(mod_info["name"], mod_info["author"], mod_info["version"], directory);
                    }
                    else
                    {
                        dt.Rows.Add(Path.GetFileName(directory), "N/A", "0.0", directory);
                    }

                }
            }
        }

        private void deleteModButton_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure you want to delete that mod?\n(Doing so means that not only will the mod be removed from this list, but the folder, and its contents will be removed as well.)",
                "Confirmation",
                MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                Directory.Delete(modLPath + @"\" + modSel, true);

                var toBeRemoved = new ArrayList();
                foreach (DataRow row in dt.Rows)
                {
                    if (row["Directory"].ToString() == modLPath + @"\" + modSel)
                    {
                        toBeRemoved.Add(row);
                    }
                }

                foreach (DataRow row in toBeRemoved)
                {
                    dt.Rows.Remove(row);
                }
            }
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {

            dt.Clear();
            var directories = Directory.GetDirectories(modLPath);

            foreach (string directory in directories)
            {
                if (File.Exists(directory + @"\info.json"))
                {
                    var json = System.IO.File.ReadAllText(directory + @"\info.json");
                    JObject mod_info = JObject.Parse(json);
                    //JArray mod_info = JArray.Parse(json);
                    dt.Rows.Add(mod_info["name"], mod_info["author"], mod_info["version"], directory);
                }
                else
                {
                    dt.Rows.Add(Path.GetFileName(directory), "N/A", "0.0", directory);
                }

            }
        }
    }
}
