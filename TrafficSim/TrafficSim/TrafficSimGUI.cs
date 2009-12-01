﻿using System;
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
            pictureBox1.Paint += new PaintEventHandler(pictureBox1_Paint);
        }

        private Road road;

        #region Graphics
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            float w = Math.Min(this.pictureBox1.Width, this.pictureBox1.Height);
            float scale = w / ((float)this.road.Width + (float)this.road.RoadRadius * 2);

            // ROAD
            float wR = (float)this.road.Width * scale;
            float wE = (float)this.road.RoadRadius * 2 * scale;
            g.DrawEllipse(new Pen(Color.Black, wR), wR / 2, wR/2, wE, wE);

            // CARS
            float wC = (float)Car.CAR_WIDTH * scale / 2;
            float lC = (float)Car.CAR_LENGTH * scale / 2;
            //Point[] carModel = {new Point(

        }
        #endregion
    }
}
