using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyAccount3Layer.GUI;
using QuanLyAccount3Layer.GUI.Admin;
using QuanLyAccount3Layer.GUI.User.mnuTienIch;

namespace QuanLyAccount3Layer
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
