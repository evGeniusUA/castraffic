using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Drawing;

namespace TrafficSim
{
    public partial class RoadViewer : Component
    {
        public RoadViewer()
        {
            InitializeComponent();
        }

        public RoadViewer(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        public Image ExportSnapShot()
        {
            throw new System.NotImplementedException();
        }

        private Road road;
    }
}
