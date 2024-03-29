﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace TrafficSim
{
    public partial class TrafficSimGUI : Form
    {
        private Road road;
        private int simspeed = 1;
        public int SimSpeed
        {
            get
            {
                return this.simspeed;
            }
            set
            {
                this.simspeed = value;
            }
        }

        public TrafficSimGUI()
        {
            this.road = new Road();
            road.Populate(60);

            InitializeComponent();
            timer1.Interval = (int)(road.TimeStepSize * 1000);
            pictureBox1.Paint += new PaintEventHandler(pictureBox1_Paint);
            label_simtime.Text = this.road.CurrentSimulationTime.ToString("F2");
            label_avgv.Text = this.road.AverageVelocityKmH.ToString("F1");
            label_flow.Text = this.road.TrafficFlowCarH.ToString("F1");
            label_density.Text = this.road.TrafficDensityCarKm.ToString("F1");
            numeric_cars.Value = this.road.NumberOfVehicles;
            numeric_speedLimit.Value = (int)this.road.DesiredVelocityKmH;
        }

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

                if (v.Acceleration >= 0.1)
                {
                    g.FillPolygon(new SolidBrush(Color.LightGreen), carModel);
                }
                else if (v.Acceleration <= -0.1)
                {
                    g.FillPolygon(new SolidBrush(Color.Red), carModel);
                }
                else
                {
                    g.FillPolygon(new SolidBrush(Color.LightGray), carModel);
                }
            }

        }
        #endregion

        #region timer
        private void timer1_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < this.SimSpeed; i++)
            {
                this.road.Iterate();
            }

            pictureBox1.Refresh();
            label_simtime.Text = this.road.CurrentSimulationTime.ToString("F2");
            label_avgv.Text = this.road.AverageVelocityKmH.ToString("F1");
            label_flow.Text = this.road.TrafficFlowCarH.ToString("F1");
            label_density.Text = this.road.TrafficDensityCarKm.ToString("F1");
        }
        #endregion

        #region buttons
        private void button_play_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button_pause_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }
       

        private void button_reset_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            this.road = new Road(this.road.RoadRadius, this.road.Width, this.road.TimeStepSize, 0.0, (double)this.numeric_speedLimit.Value / 3.6);
            label_simtime.Text = this.road.CurrentSimulationTime.ToString("F2");
            this.road.Populate((int)numeric_cars.Value);
            pictureBox1.Refresh();
        }

        private void numeric_cars_ValueChanged(object sender, EventArgs e)
        {
            this.button_reset_Click(sender, e);
        }

        private void numeric_speedLimit_ValueChanged(object sender, EventArgs e)
        {
            this.button_reset_Click(sender, e);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.timer1_Tick(sender, e);
        }

        private void radio_simspeed1_CheckedChanged(object sender, EventArgs e)
        {
            if (radio_simspeed1.Checked) { this.SimSpeed = 1; }
        }

        private void radio_simspeed5_CheckedChanged(object sender, EventArgs e)
        {
            if (radio_simspeed5.Checked) { this.SimSpeed = 5; }
        }

        private void radio_simspeed10_CheckedChanged(object sender, EventArgs e)
        {
            if (radio_simspeed10.Checked) { this.SimSpeed = 10; }
        }

        private void radio_simspeed30_CheckedChanged(object sender, EventArgs e)
        {
            if (radio_simspeed30.Checked) { this.SimSpeed = 100; }
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            // Displays a SaveFileDialog so the user can save the Configuration
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Matlab m-file (*.m)|*.m|Any file (*.*)|*.*";
            saveFileDialog1.Title = "Save Current Simulation-data to Matlab m-file";
            saveFileDialog1.ShowDialog();

            // If the file name is not an empty string open it for saving.
            if (saveFileDialog1.FileName != "")
            {
                StringBuilder sb = new StringBuilder();
                sb.Append(this.road.MatlabSettings);
                sb.Append("\n\n");
                sb.Append(this.road.MatlabTime);
                sb.Append("\n\n");
                sb.Append(this.road.MatlabPositions);
                sb.Append("\n\n");
                sb.Append(this.road.MatlabVelocities);
                sb.Append("\n\n");
                sb.Append(this.road.MatlabAccelerations);
                sb.Append("\n\n");

                System.IO.StreamWriter sw = new StreamWriter(saveFileDialog1.OpenFile());
                sw.Write(sb.ToString());
                sw.Close();
            }
        }
        #endregion
    }
}
