using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace FogBugzApi
{
	public partial class NotificationsForm : Form
	{
		public NotificationsForm()
		{
			InitializeComponent();

			Rectangle workingArea = System.Windows.Forms.Screen.PrimaryScreen.WorkingArea;
			int left = workingArea.Width - this.Width;
			int top = workingArea.Height - this.Height;

			this.StartPosition = FormStartPosition.Manual;
			this.ShowInTaskbar = true;
			this.WindowState = FormWindowState.Normal;
			this.DesktopLocation = new Point(left, top);
			this.TopMost = true;
		}

		public int CasesCount { set { casesCountLabel.Text = value.ToString(); } }

		private void viewButton_Click(object sender, EventArgs e)
		{
			Form mainForm = Application.OpenForms["MainForm"];

			if (mainForm.Visible == false)
			{
				mainForm.Show();
				mainForm.WindowState = FormWindowState.Normal;
				mainForm.BringToFront();
			}
			else if (mainForm.WindowState == FormWindowState.Minimized)
			{
				mainForm.WindowState = FormWindowState.Normal;
				mainForm.BringToFront();
			}
			else
			{
				mainForm.BringToFront();
			}

			this.Close();
		}

		private void closeButton_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}

