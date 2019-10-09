using System;
using System.Windows.Forms;

namespace MS_Lab1
{
    static class Program
    {
        public static FormMain formMain;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(formMain = new FormMain());
        }
    }
}
