using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMS
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

            MainForm = new mainWindow();
            Application.Run(MainForm);
        }

        private static mainWindow MainForm { get; set; }

        public static mainWindow MainWindow 
        {
            get { return MainForm; }
        }
    }
}
