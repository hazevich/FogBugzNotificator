using FogBugzApi;
using System;
using System.Threading;
using System.Windows.Forms;
using FogBugzNotificator.Popups;

namespace FogBugzNotificator
{
    public partial class LoginForm : Form
    {
        IFogBugzClient _fbAuth;
        bool _auth;

        public LoginForm()
        {
            InitializeComponent();
			this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(loginBox.Text) || string.IsNullOrEmpty(passwordBox.Text))
            {
                InvokeFromUIThread(() =>
                    {
                        errorLabel.Text = "Credentials can't be empty";
                        errorLabel.Visible = true;
                    });
            }
            else
            {
                InvokeFromUIThread(() =>
                    {
                        errorLabel.Visible = false;
                        EnableInputs(false);
                    });

                if (string.IsNullOrEmpty(Properties.Settings.Default.FogBugzUrl))
                {
                    new FreshInstallPopup().ShowDialog();
                            

                    InvokeFromUIThread(() => EnableInputs(true));
                }
                else
                {
                    _auth = false;

                    try
                    { 
                        _fbAuth = new FogBugzClient(Properties.Settings.Default.FogBugzUrl);

                        _auth = _fbAuth.Auth(@loginBox.Text, @passwordBox.Text);
                    }
                    catch
                    {
                        new ConnectionErrorPopup().ShowDialog();
                    }
                    if (_auth)
                    {
                        InvokeFromUIThread(() =>
                            {
                                MainForm main = new MainForm(_fbAuth);
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
        }

		private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
		{
            if(!_auth)
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
