using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dziennik
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
            LoginForm loginF = new LoginForm();
            if (loginF.ShowDialog() == DialogResult.OK)
            {
                MenuForm menuF = new MenuForm((string)loginF.Tag);
                Application.Run(menuF);
            }
            else
            {
                Application.Exit();
            }
        }
    }
}
