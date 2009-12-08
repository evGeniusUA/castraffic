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
            Road road = new Road();
            road.Populate(30);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new TrafficSimGUI(road));
        }
    }
}
