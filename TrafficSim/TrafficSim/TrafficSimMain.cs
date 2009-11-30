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
            Road road = new Road(1000.0 / (2 * Math.PI), 0.1, 0.0);
            road.Populate(20);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new TrafficSimGUI(road));
        }
    }
}
