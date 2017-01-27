﻿using System;
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
            path = Application.ExecutablePath.Substring(0, Application.ExecutablePath.LastIndexOf('\\')+1);
            Application.Run(new LoginForm());
        }
    }
}
