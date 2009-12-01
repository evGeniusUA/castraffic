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
            this.road = road;
            InitializeComponent();
            this.Paint += new PaintEventHandler(panel1_Paint);
        }

        private Road road;

        #region Graphics
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            float w = Math.Min(panel1.Width, panel1.Height);
            float scale = w / ((float)this.road.RoadRadius * 2);

            g.DrawEllipse(new Pen(Color.Black, (float)this.road.Width * scale), 0, 0, w, w);

        }
        #endregion
    }
}
