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
    public partial class ConnectionErrorPopup : Form
    {
        public ConnectionErrorPopup()
        {
            InitializeComponent();
            errorMessage.Text += " " + Properties.Settings.Default.FogBugzUrl;  
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
