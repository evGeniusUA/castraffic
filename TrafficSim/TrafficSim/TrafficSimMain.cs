using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace TrafficSim
{
    static class TrafficSimMain
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new TrafficSimGUI());
            
            // To be exchanged for
            //Application.Run( new TrafficSimGUI(new Road(...)) );
        }
    }
}
