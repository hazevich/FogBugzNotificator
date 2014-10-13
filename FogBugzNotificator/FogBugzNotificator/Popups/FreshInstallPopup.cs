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

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void setupButton_Click(object sender, EventArgs e)
        {
            new SettingsForm().ShowDialog();
            this.Dispose();
        }
    }
}
