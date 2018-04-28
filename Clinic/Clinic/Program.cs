using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataLayer;

namespace Przychodnia
{
    static class Program
    {
        public static bool Close { get; internal set; }
        public static Employee CurrentUser { get; internal set; }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Program.Close = false;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new SignInForm());
        }
    }
}
