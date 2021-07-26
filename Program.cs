using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsCLogin
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
            //Application.Run(new CLogin());
          Application.Run(new display());
            //Application.Run(new UpdateStuff());
          //Application.Run(new PlaceOrder());          
          // Application.Run(new Main_display());
        }
    }
}
