using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FogBugzNotificator.Popups
{
    public partial class FreshInstallPopup : Form
    {
        public FreshInstallPopup()
        {
            InitializeComponent();
        }

        private SettingsForm _settingsForm = new SettingsForm();

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void setupButton_Click(object sender, EventArgs e)
        {
            _settingsForm.ShowDialog();
            this.Close();
        }
    }
}
