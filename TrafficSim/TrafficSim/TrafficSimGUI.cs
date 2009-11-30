using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TrafficSim
{
    public partial class TrafficSimGUI : Form
    {
        public TrafficSimGUI(Road road)
        {
            this.Road = road;
            InitializeComponent();
        }

        private Road Road
        {
            get
            {
                return this.Road;
            }
            set
            {
            }
        }
    }
}
