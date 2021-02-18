using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA210218
{
    static class Program
    {
        internal static string dbFileLocation;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            dbFileLocation = AppDomain.CurrentDomain.BaseDirectory
                .Replace(@"bin\Debug\", @"AppData\kozossegiSzolgalat.mdf");
            Debug.WriteLine(AppDomain.CurrentDomain.BaseDirectory);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmMain());
        }
    }
}
