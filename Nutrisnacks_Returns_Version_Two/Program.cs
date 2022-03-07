using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Nutrisnacks_Returns_Version_Two
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
            Application.Run(new Nutrisnacks_Returns_Version_Two.main_form());
        }
    }
}
