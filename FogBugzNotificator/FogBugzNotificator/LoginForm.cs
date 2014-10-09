using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using FogBugzApi;

namespace FogBugzNotificator
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
			this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
           Thread checkCredsThread = new Thread(new ThreadStart(() =>
                {
                    if (string.IsNullOrEmpty(loginBox.Text) || string.IsNullOrEmpty(passwordBox.Text))
                    {
                        this.Invoke(new MethodInvoker(() =>
                            {
                                errorLabel.Text = "Credentials can't be empty";
                                errorLabel.Visible = true;
                            }));
                    }
                    else
                    {
                        InvokeFromUIThread(() =>
                            {
                                errorLabel.Visible = false;
                                EnableInputs(false);
                            });

                        if (String.IsNullOrEmpty(Properties.Settings.Default.FogBugzUrl))
                        {
                            MessageBox.Show("You need to provide your FogBugz URL");

                            InvokeFromUIThread(() => EnableInputs(true));
                        }
                        else
                        {
                            IFogBugzClient fbAuth = new FogBugzClient(Properties.Settings.Default.FogBugzUrl);

                            bool auth = fbAuth.Auth(@loginBox.Text, @passwordBox.Text);

                            if (auth)
                            {
                                InvokeFromUIThread(() =>
                                    {
                                        MainForm main = new MainForm(fbAuth);
                                        main.Show();
                                        this.Close();
                                    });
                            }
                            else
                            {
                                InvokeFromUIThread(() =>
                                    {
                                        EnableInputs(true);
                                        errorLabel.Text = "Wrong login or password";
                                        errorLabel.Visible = true;
                                    });
                            }
                        }
                    }
                }));

		   checkCredsThread.Name = "Check Creds Thread";
		   checkCredsThread.IsBackground = true;
		   checkCredsThread.Start();

        }

		private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			Application.Exit();
		}

        private void EnableInputs(bool enable)
        {
            loginBox.Enabled = enable;
            passwordBox.Enabled = enable;
            loginButton.Enabled = enable;
        }

        private void InvokeFromUIThread(Action action)
        {
            this.Invoke(new MethodInvoker(() => action() ));
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            new SettingsForm().ShowDialog();
        }
    }
}
