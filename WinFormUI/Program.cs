using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace WinFormUI
{
    static class Program
    {
        // ConnectForm disabled
        // static internal ConnectForm connectForm = null;
        static internal MainForm mainForm = null;
        static internal ReportForm reportForm = null;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(mainForm = new MainForm());
        }
    }
}
