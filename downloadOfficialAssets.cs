using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BuildAndShootLauncher2
{
    public partial class downloadOfficialAssets : Form
    {
        public DataTable dt = new DataTable();
        public string dl_url;
        public downloadOfficialAssets()
        {
            InitializeComponent();

            dt.Columns.Add(new DataColumn("Name", typeof(string)));
            dt.Columns.Add(new DataColumn("Author", typeof(string)));
            dt.Columns.Add(new DataColumn("Version", typeof(double)));
            dt.Columns.Add(new DataColumn("Source", typeof(string)));

            dt.Rows.Add("Modloader", "learn_more", 1.51, "https://dl-web.dropbox.com/get/modloader-installer.exe?_subject_uid=572970788&w=AADKaFDULc2rJSQNCC4yr38LIVuXl-xNOq-kqFRrhZoeew&dl=1&_download_id=73134449875799128007229410905375346337120706777038349912762140725&_notify_domain=www.dropbox.com");
            dt.Rows.Add("pubovl", "topo", 0.0, "https://dl-web.dropbox.com/get/pubovl.dll?_subject_uid=572970788&w=AAAWuw4extQ2HIGTmq6ooPGgt9LCxEG2vHJp4y-9a3EX-Q&dl=1&_download_id=0917182125645259535974154701108217193588263149444899344981750049&_notify_domain=www.dropbox.com");

            offAssetDataGrid.DataSource = dt;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void offAssetDataGrid_SelectionChanged(object sender, EventArgs e)
        {
            if (offAssetDataGrid.SelectedCells.Count > 0)
            {
                int selectedrowindex = offAssetDataGrid.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = offAssetDataGrid.Rows[selectedrowindex];
                dl_url = Convert.ToString(selectedRow.Cells["Source"].Value);
            }
        }

        private void downloadInstallButton_Click(object sender, EventArgs e)
        {

        }
    }
}
