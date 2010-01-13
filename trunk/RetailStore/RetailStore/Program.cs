using System;
using System.Collections.Generic;
using System.Windows.Forms;
using RetailStore.Presentation_Layer;
using RetailStore.Crystal_Reports;
namespace RetailStore
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
            Application.Run(new frmMDI());
        }
    }
}