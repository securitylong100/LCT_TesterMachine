using System;
using System.Windows.Forms;

namespace AdvancedHMICS
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
            //Application.Run(new frmMain());
            // Application.Run(new MainForm());
            Application.Run(new LoginForm());
            //Application.Run(new frmQuerySQLite());
            //Application.Run(new frmQuerySQLite());
            //Application.Run(new frmSettingModel());
        }
    }
}
