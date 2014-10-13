using System;
using System.Net;
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

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
