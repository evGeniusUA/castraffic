using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
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
            int wCu = (int)Math.Round(wR/2 + Car.CAR_WIDTH * scale / 2);
            int wCl = (int)Math.Round(wR/2 - Car.CAR_WIDTH * scale / 2);
            int lCl = (int)Math.Round(wE/2 + wR/2 - Car.CAR_LENGTH * scale / 2);
            int lCr = (int)Math.Round(wE/2 + wR/2 + Car.CAR_LENGTH * scale / 2);

            foreach (Vehicle v in road.Vehicles)
            {
                Point[] carModel = { new Point(lCl, wCu), new Point(lCr, wCu), new Point(lCr, wCl), new Point(lCl, wCl) };
                Matrix transMatrix = new Matrix();
                transMatrix.RotateAt((float)v.Position.ToDegrees(), new PointF((wE + wR) / 2, (wE + wR) / 2));
                transMatrix.TransformPoints(carModel);

                g.FillPolygon(new SolidBrush(Color.Red), carModel);
            }

        }
        #endregion
    }
}
