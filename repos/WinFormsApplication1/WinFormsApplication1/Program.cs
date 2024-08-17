using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Channels;
using System.Windows.Forms;
namespace WinFormsApplication1
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);   
            Application.Run(new FRM_GRIDVIEW());
        }
    }
}