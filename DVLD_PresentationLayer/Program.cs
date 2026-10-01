using DVLD_BusinessLayer;
using DVLD_PresentationLayer.Tests;
using System;
using System.Windows.Forms;

namespace DVLD_PresentationLayer
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
            Application.Run(new frmLogin());
           
     
        }
    }
}
