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
using BuildAndShootLauncher2;

namespace BuildAndShootLauncher2
{
    public partial class directConnectPopup : Form
    {
        public directConnectPopup()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void serverBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void connectConfirmButton_Click(object sender, EventArgs e)
        {
            //BuildAndShootLauncher2.Utilities utils = new BuildAndShootLauncher2.Utilities();

            if (serverBox.Text != "")
            {
                Utilities utils = new Utilities();
                utils.runSpades(serverBox.Text);
                this.Close();
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
