using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FogBugzNotificator
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
            this.urlTextBox.Text = Properties.Settings.Default.FogBugzUrl;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                WebRequest.Create(urlTextBox.Text);
                Properties.Settings.Default.FogBugzUrl = urlTextBox.Text;
                Properties.Settings.Default.Save();
                this.Close();
            }
            catch(UriFormatException ex)
            {
                MessageBox.Show("Wrong URL");
            }

        }
    }
}
