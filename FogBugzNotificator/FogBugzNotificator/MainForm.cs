using FogBugzApi;
using FogBugzApi.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using FogBugzNotificator.Popups;

namespace FogBugzNotificator
{
    public partial class MainForm : Form
    {
        public MainForm(IFogBugzClient fbClient)
        {
            InitializeComponent();
			_fogBugz = fbClient;
			this.StartPosition = FormStartPosition.CenterScreen;
            _aboutPopup.Version = "BETA v1.3";
        }

        private ConnectionErrorPopup _connectionErrorPopup = new ConnectionErrorPopup();
        private NotificationsForm _notificationForm = new NotificationsForm();
        private AboutPopup _aboutPopup = new AboutPopup();
        private IFogBugzClient _fogBugz;
		private List<FogBugzCase> _currentCases;
        private System.Timers.Timer notifTimer = new System.Timers.Timer();

        private void SetupTimer()
        {
            notifTimer.Elapsed += notifTimer_Elapsed;
            notifTimer.Interval = 300000;
            notifTimer.Enabled = true;
        }

        private void notifTimer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            
            var cases = new List<FogBugzCase>();
            TryToRequest(() => cases = _fogBugz.GetCasesAssignedToCurrentUser());

            if (cases != null || cases.Count > 0)
            {
                var newCases = new List<FogBugzCase>();

                cases.ForEach(c =>
                    {
                        if (!_currentCases.Contains(c))
                        {
                            newCases.Add(c);
                        }
                    });

                if (newCases.Count > 0)
                {
                    this.Invoke(new MethodInvoker(() =>
                    {
                        casesListView.Items.Clear();

                        newCases.ForEach(c =>
                            {
                                var item = new ListViewItem(new string[] { c.Id.ToString(), c.Title, c.Status, c.Priority });
                                item.BackColor = Color.DarkOrange;
                                casesListView.Items.Add(item);

                                cases.Remove(c);
                            });

                        cases.ForEach(c =>
                            {
                                var item = new ListViewItem(new string[] { c.Id.ToString(), c.Title, c.Status, c.Priority });
                                casesListView.Items.Add(item);
                            });
                    }));

                    Thread notificationThread = new Thread(new ThreadStart(() =>
                    {
                            this.Invoke(new MethodInvoker(() =>
                            {
                                _notificationForm.CasesCount = newCases.Count;
                                _notificationForm.Show();
                                _notificationForm.BringToFront();
                            }));
                    }));

                    notificationThread.Name = "Notification Thread";
                    notificationThread.IsBackground = true;
                    notificationThread.Start();

                    _currentCases = new List<FogBugzCase>();
                    _currentCases.AddRange(newCases);
                    _currentCases.AddRange(cases);
                }
             
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            var cases = new List<FogBugzCase>();
            TryToRequest(() => cases = _fogBugz.GetCasesAssignedToCurrentUser());

			_currentCases = cases;

			cases.ForEach(c =>
                casesListView.Items.Add(new ListViewItem(new string[] { c.Id.ToString(), c.Title, c.Status, c.Priority })));

            SetupTimer();
		}

		private void casesListView_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			ListViewHitTestInfo hitTest = casesListView.HitTest(e.X, e.Y);
			ListViewItem item = hitTest.Item;

			if (item != null)
				Process.Start(string.Format("{0}/default.asp?{1}", Properties.Settings.Default.FogBugzUrl, item.SubItems[0].Text));
		}

		private void refreshCasesListButton_Click(object sender, EventArgs e)
		{

			Thread refreshListThread = new Thread(new ThreadStart(() =>
				{
					this.Invoke(new MethodInvoker(() =>
						{
							refreshCasesListButton.Enabled = false;
							casesListView.Items.Clear();
						}));

                    var cases = new List<FogBugzCase>();

                    TryToRequest(() => cases = _fogBugz.GetCasesAssignedToCurrentUser());
                     
					this.Invoke(new MethodInvoker(() =>
						{
                            cases.ForEach(c =>
                                {
                                    casesListView.Items.Add(new ListViewItem(new string[] { c.Id.ToString(), c.Title, c.Status, c.Priority }));
                                    refreshCasesListButton.Enabled = true;
                                });
						}));
				}));

			refreshListThread.Name = "Refresh List Thread";
			refreshListThread.IsBackground = true;
			refreshListThread.Start();
			
		}

		private void NewCasesHandler()
		{
			Thread handlerThread = new Thread(new ThreadStart(() =>
			{
				while (true)
				{

                    
					Thread.Sleep(TimeSpan.FromSeconds(10));
				}
			}));

			handlerThread.Name = "New Case Handler Thread";
			handlerThread.IsBackground = true;
			handlerThread.Start();
		}
		private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			e.Cancel = true;
			this.Hide();
			this.trayIcon.Visible = true;
		}

		private void casesListView_MouseClick(object sender, MouseEventArgs e)
		{
			ListViewHitTestInfo hitTest = casesListView.HitTest(e.X, e.Y);
			ListViewItem item = hitTest.Item;

			if (item != null)
			{
				if (item.BackColor != casesListView.BackColor)
				{
					item.BackColor = casesListView.BackColor;
				}
			}
		}

		private void exitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var confirmResult = MessageBox.Show("Are you sure you want to exit?", "Confirm exit", MessageBoxButtons.YesNo);

			if (confirmResult == DialogResult.Yes)
			{
                _fogBugz.LogOff();
				this.Dispose();
				Application.Exit();
			}
		}

		private void trayIcon_DoubleClick(object sender, EventArgs e)
		{
			this.Show();
			this.BringToFront();
			this.WindowState = FormWindowState.Normal;
		}

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure you want to LogOut?", "Confirm LogOut", MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes)
            {
                _fogBugz.LogOff();
                new LoginForm().Show();
                this.Dispose();
            }
        }

        private void TryToRequest(Action action)
        {
            try
            {
                action();
            }
            catch(Exception ex)
            {
                Debug.WriteLine(ex.Message);
                _connectionErrorPopup.ShowDialog();
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _aboutPopup.ShowDialog();
        }
    }
}
