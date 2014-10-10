using System;
using System.Windows.Forms;

namespace FogBugzNotificator
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var loginForm = new LoginForm();
            loginForm.Show();

            Application.Run();
        }
    }
}
