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

namespace FogBugzNotificator.Popups
{
    public partial class AboutPopup : Form
    {
        public AboutPopup()
        {
            InitializeComponent();
        }

        private void developerLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.linkedin.com/profile/view?id=254490963");
        }

        private void projectLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/hazevich/FogBugzNotificator/wiki");
        }

        public string Version
        {
            get
            {
                return this.versionLabel.Text;
            }
            set
            {
                this.versionLabel.Text = value;
            }
        }
    }
}
