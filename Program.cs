using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TV_advert_WF
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            int role = Auth();
            if (role > 0)
                Application.Run(new MainForm(role));
        }
        static int Auth()
        {
            var dialog = new AuthorizationForm();
            dialog.ShowDialog();
            return dialog.Role;
        }
    }
}
