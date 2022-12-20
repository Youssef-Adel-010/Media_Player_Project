using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using DesignTest;

namespace DesignTest
{
    public class media
    {
        private string file_name = null;
        private string file_path = null;
        public media(string name, string path)
        {
            file_name = name;
            file_path = path;
        }
        public string name()
        {
            return file_name;
        }
        public string path()
        {
            return file_path;
        }
    }
}

namespace oop_gui_project
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
            Application.Run(new Login());
        }
    }
}
