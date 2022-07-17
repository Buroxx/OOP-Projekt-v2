using OOPLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            switch (Repository.LoadSettings())
            {
                case 's':
                    Application.Run(new Settings());
                    break;
                case 'f':
                    Application.Run(new FavoriteTeam());
                    break;
                case 'a':
                    Application.Run(new MainForm());
                    break;
                default:
                    break;
            }
        }
    }
}
