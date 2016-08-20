using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BuildAndShootLauncher2
{
    public partial class versionsInstaller : Form
    {
        public string versionSel;
        public Dictionary<string, string> versionInf = new Dictionary<string, string>();
        public versionsInstaller()
        {
            InitializeComponent();

            versionSetupLabel.Text = "Please select which version you would like to install...\n\nAlternatively, you may close this window and choose to use your Appdata directory instead via the Setup menu.";
            versionInf["0.76"] = "https://www.dropbox.com/s/bay6suukl085s5s/076.zip?dl=0&raw=1";
            versionInf["0.75"] = "https://www.dropbox.com/s/s4lvsys8815l52g/075.zip?dl=0&raw=1";
            versionInf["0.54"] = "https://www.dropbox.com/s/21xdv94vjxp26zz/054.zip?dl=0&raw=1";
            versionInf["0.50"] = "https://www.dropbox.com/s/pn6kstw4fmn40uw/050.zip?dl=0&raw=1";
            versionInf["0.49"] = "https://www.dropbox.com/s/ga7bvc9sd01hzdt/049.zip?dl=0&raw=1";

            DataTable dt = new DataTable();

            dt.Columns.Add(new DataColumn("Version", typeof(string)));
            dt.Columns.Add(new DataColumn("Full Support", typeof(string)));

            dt.Rows.Add("0.76", "No");
            dt.Rows.Add("0.75", "Yes");
            dt.Rows.Add("0.54", "No");
            dt.Rows.Add("0.50", "No");
            dt.Rows.Add("0.49", "No");
            
            versionSelectGrid.DataSource = dt;

            versionSelectGrid.Columns[0].Width = 400;
            versionSelectGrid.Columns[1].Width = 152;
        }

        private void versionSelectGrid_SelectionChanged(object sender, EventArgs e)
        {
            if (versionSelectGrid.SelectedCells.Count > 0)
            {
                int selectedrowindex = versionSelectGrid.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = versionSelectGrid.Rows[selectedrowindex];
                versionSel = Convert.ToString(selectedRow.Cells["Version"].Value);
            }
        }

        private void installButton_Click(object sender, EventArgs e)
        {
            var progressBar = new emptyProgressBar();
            progressBar.Show();
            if (!Directory.Exists(Directory.GetCurrentDirectory() + @"\versions"))
                Directory.CreateDirectory(Directory.GetCurrentDirectory() + @"\versions");
            if (!Directory.Exists(Directory.GetCurrentDirectory() + @"\versions\" + versionSel))
                Directory.CreateDirectory(Directory.GetCurrentDirectory() + @"\versions\" + versionSel);
            else
            {
                MessageBox.Show("That version has already been installed.");
                progressBar.Close();
                return;
            }

            int selectedrowindex = versionSelectGrid.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = versionSelectGrid.Rows[selectedrowindex];
            var supported = Convert.ToString(selectedRow.Cells["Full Support"].Value);

            if (supported == "No")
                MessageBox.Show("That version has not been fully supported. Because of this, some launcher features may not work properly.", "Warning!");

            using (var client = new WebClient())
            {
                client.DownloadFile(versionInf[versionSel], versionSel.Replace(".", "") + ".zip");
            }

            string archivePath = versionSel.Replace(".", "") + ".zip";
            string extractPath = Directory.GetCurrentDirectory() + @"\versions\" + versionSel;

            using (ZipArchive archive = ZipFile.OpenRead(archivePath))
            {
                // get the root directory
                var root = archive.Entries[0]?.FullName;
                if (root == null)
                {
                    // quit in a nice way
                }
                var result = from curr in archive.Entries
                             where Path.GetDirectoryName(curr.FullName) != root
                             where !string.IsNullOrEmpty(curr.Name)
                             select curr;

                foreach (ZipArchiveEntry entry in result)
                {
                    var newName = entry.FullName.Substring(root.Length);
                    string path = Path.Combine(extractPath, newName);

                    if (!Directory.Exists(path))
                        Directory.CreateDirectory(Path.GetDirectoryName(path));

                    entry.ExtractToFile(path);
                }
            }
            File.Delete(archivePath);
            progressBar.Close();
            this.Close();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
