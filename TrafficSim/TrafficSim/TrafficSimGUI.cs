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
            InitializeComponent();
        }

        public TrafficSimGUI()
        {
            throw new System.NotImplementedException();
        }

        public int Road
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }
    }
}
