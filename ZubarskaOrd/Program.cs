using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZubarskaOrd
{
    static class Program
    {
        public static string path;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            path = Application.ExecutablePath.Substring(0, Application.ExecutablePath.LastIndexOf('\\'));
            path = path.Substring(0, path.LastIndexOf('\\'));
            path = path.Substring(0, path.LastIndexOf('\\'));
            path = path.Substring(0, path.LastIndexOf('\\')+1);
            Application.Run(new Forms.InterventionForm(13));
        }
    }
}
//C:\Users\hp\Desktop\Informacioni\2016-zubna-ordinacija\ZubarskaOrd\bin\Debug