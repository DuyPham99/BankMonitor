using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.UserSkins;
using DevExpress.Skins;
using DevExpress.LookAndFeel;
using BankMonitor.model;
using System.Data.SqlClient;

namespace BankMonitor
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application..
        /// </summary>
  
      // [STAThread]
        static void Main(string[] arg)
        {
            Console.Write("Hello");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
