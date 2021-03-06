using System;
using System.Windows.Forms;

namespace PJesus_Task.WF
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
            // Application.Run(new frmTask1());
            Application.Run(new frmTask2());
        }
    }
}
