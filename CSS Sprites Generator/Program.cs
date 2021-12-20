using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CSS_Sprites_Generator
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

            ExceptionHandlersHelper.AddUnhandledExceptionHandlers();

            Application.Run(new frmMain());
        }
    }
}
