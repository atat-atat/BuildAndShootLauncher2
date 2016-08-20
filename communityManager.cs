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
    public partial class communityManager : Form
    {
        public communityManager()
        {
            InitializeComponent();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void downloadOffAssets_Click(object sender, EventArgs e)
        {
            var officialAssets = new downloadOfficialAssets();
            officialAssets.ShowDialog(this);
        }
    }
}
