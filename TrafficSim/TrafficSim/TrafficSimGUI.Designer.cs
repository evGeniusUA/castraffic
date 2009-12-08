namespace TrafficSim
{
    partial class TrafficSimGUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrafficSimGUI));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label_simtime = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.button_play = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.button_pause = new System.Windows.Forms.ToolStripButton();
            this.button_reset = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.button_save = new System.Windows.Forms.ToolStripButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.numeric_cars = new System.Windows.Forms.NumericUpDown();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radio_simspeed30 = new System.Windows.Forms.RadioButton();
            this.radio_simspeed10 = new System.Windows.Forms.RadioButton();
            this.radio_simspeed5 = new System.Windows.Forms.RadioButton();
            this.radio_simspeed1 = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numeric_speedLimit = new System.Windows.Forms.NumericUpDown();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label_avgv = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label_flow = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label_density = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_cars)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_speedLimit)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Location = new System.Drawing.Point(12, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(381, 413);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label_simtime);
            this.groupBox1.Location = new System.Drawing.Point(399, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(96, 40);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Run Time";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(12, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "s";
            // 
            // label_simtime
            // 
            this.label_simtime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_simtime.AutoSize = true;
            this.label_simtime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_simtime.Location = new System.Drawing.Point(12, 16);
            this.label_simtime.MinimumSize = new System.Drawing.Size(60, 0);
            this.label_simtime.Name = "label_simtime";
            this.label_simtime.Size = new System.Drawing.Size(60, 13);
            this.label_simtime.TabIndex = 0;
            this.label_simtime.Text = "0.0";
            this.label_simtime.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.button_play,
            this.toolStripButton1,
            this.button_pause,
            this.button_reset,
            this.toolStripSeparator1,
            this.button_save});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(507, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // button_play
            // 
            this.button_play.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.button_play.Image = ((System.Drawing.Image)(resources.GetObject("button_play.Image")));
            this.button_play.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.button_play.Name = "button_play";
            this.button_play.Size = new System.Drawing.Size(23, 22);
            this.button_play.Text = "Run simulation";
            this.button_play.Click += new System.EventHandler(this.button_play_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "Step";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // button_pause
            // 
            this.button_pause.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.button_pause.Image = ((System.Drawing.Image)(resources.GetObject("button_pause.Image")));
            this.button_pause.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.button_pause.Name = "button_pause";
            this.button_pause.Size = new System.Drawing.Size(23, 22);
            this.button_pause.Text = "Pause Simulation";
            this.button_pause.Click += new System.EventHandler(this.button_pause_Click);
            // 
            // button_reset
            // 
            this.button_reset.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.button_reset.Image = ((System.Drawing.Image)(resources.GetObject("button_reset.Image")));
            this.button_reset.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.button_reset.Name = "button_reset";
            this.button_reset.Size = new System.Drawing.Size(23, 22);
            this.button_reset.Text = "Reset Simulation";
            this.button_reset.Click += new System.EventHandler(this.button_reset_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // button_save
            // 
            this.button_save.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.button_save.Image = ((System.Drawing.Image)(resources.GetObject("button_save.Image")));
            this.button_save.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(23, 22);
            this.button_save.Text = "Export Simulation-data to Matlab";
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.numeric_cars);
            this.groupBox2.Location = new System.Drawing.Point(399, 194);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(96, 52);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "# Cars";
            // 
            // numeric_cars
            // 
            this.numeric_cars.Location = new System.Drawing.Point(6, 19);
            this.numeric_cars.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numeric_cars.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numeric_cars.Name = "numeric_cars";
            this.numeric_cars.Size = new System.Drawing.Size(84, 20);
            this.numeric_cars.TabIndex = 0;
            this.numeric_cars.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numeric_cars.ValueChanged += new System.EventHandler(this.numeric_cars_ValueChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.radio_simspeed30);
            this.groupBox3.Controls.Add(this.radio_simspeed10);
            this.groupBox3.Controls.Add(this.radio_simspeed5);
            this.groupBox3.Controls.Add(this.radio_simspeed1);
            this.groupBox3.Location = new System.Drawing.Point(399, 75);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(96, 113);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Sim Speed";
            // 
            // radio_simspeed30
            // 
            this.radio_simspeed30.AutoSize = true;
            this.radio_simspeed30.Location = new System.Drawing.Point(15, 88);
            this.radio_simspeed30.Name = "radio_simspeed30";
            this.radio_simspeed30.Size = new System.Drawing.Size(45, 17);
            this.radio_simspeed30.TabIndex = 3;
            this.radio_simspeed30.Text = "x 30";
            this.radio_simspeed30.UseVisualStyleBackColor = true;
            this.radio_simspeed30.CheckedChanged += new System.EventHandler(this.radio_simspeed30_CheckedChanged);
            // 
            // radio_simspeed10
            // 
            this.radio_simspeed10.AutoSize = true;
            this.radio_simspeed10.Location = new System.Drawing.Point(15, 65);
            this.radio_simspeed10.Name = "radio_simspeed10";
            this.radio_simspeed10.Size = new System.Drawing.Size(45, 17);
            this.radio_simspeed10.TabIndex = 2;
            this.radio_simspeed10.Text = "x 10";
            this.radio_simspeed10.UseVisualStyleBackColor = true;
            this.radio_simspeed10.CheckedChanged += new System.EventHandler(this.radio_simspeed10_CheckedChanged);
            // 
            // radio_simspeed5
            // 
            this.radio_simspeed5.AutoSize = true;
            this.radio_simspeed5.Location = new System.Drawing.Point(15, 42);
            this.radio_simspeed5.Name = "radio_simspeed5";
            this.radio_simspeed5.Size = new System.Drawing.Size(39, 17);
            this.radio_simspeed5.TabIndex = 1;
            this.radio_simspeed5.Text = "x 5";
            this.radio_simspeed5.UseVisualStyleBackColor = true;
            this.radio_simspeed5.CheckedChanged += new System.EventHandler(this.radio_simspeed5_CheckedChanged);
            // 
            // radio_simspeed1
            // 
            this.radio_simspeed1.AutoSize = true;
            this.radio_simspeed1.Checked = true;
            this.radio_simspeed1.Location = new System.Drawing.Point(15, 19);
            this.radio_simspeed1.Name = "radio_simspeed1";
            this.radio_simspeed1.Size = new System.Drawing.Size(39, 17);
            this.radio_simspeed1.TabIndex = 0;
            this.radio_simspeed1.TabStop = true;
            this.radio_simspeed1.Text = "x 1";
            this.radio_simspeed1.UseVisualStyleBackColor = true;
            this.radio_simspeed1.CheckedChanged += new System.EventHandler(this.radio_simspeed1_CheckedChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.numeric_speedLimit);
            this.groupBox4.Location = new System.Drawing.Point(399, 252);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(96, 52);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Speed Limit";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "km/h";
            // 
            // numeric_speedLimit
            // 
            this.numeric_speedLimit.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numeric_speedLimit.Location = new System.Drawing.Point(6, 19);
            this.numeric_speedLimit.Maximum = new decimal(new int[] {
            250,
            0,
            0,
            0});
            this.numeric_speedLimit.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numeric_speedLimit.Name = "numeric_speedLimit";
            this.numeric_speedLimit.Size = new System.Drawing.Size(54, 20);
            this.numeric_speedLimit.TabIndex = 0;
            this.numeric_speedLimit.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numeric_speedLimit.ValueChanged += new System.EventHandler(this.numeric_speedLimit_ValueChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Controls.Add(this.label_avgv);
            this.groupBox5.Location = new System.Drawing.Point(399, 310);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(96, 40);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Avg. Velocity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "km/h";
            // 
            // label_avgv
            // 
            this.label_avgv.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_avgv.AutoSize = true;
            this.label_avgv.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_avgv.Location = new System.Drawing.Point(12, 16);
            this.label_avgv.MinimumSize = new System.Drawing.Size(50, 0);
            this.label_avgv.Name = "label_avgv";
            this.label_avgv.Size = new System.Drawing.Size(50, 13);
            this.label_avgv.TabIndex = 0;
            this.label_avgv.Text = "0.0";
            this.label_avgv.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // groupBox6
            // 
            this.groupBox6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox6.Controls.Add(this.label4);
            this.groupBox6.Controls.Add(this.label_flow);
            this.groupBox6.Location = new System.Drawing.Point(399, 356);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(96, 40);
            this.groupBox6.TabIndex = 3;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Avg. Flow";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "cars/h";
            // 
            // label_flow
            // 
            this.label_flow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_flow.AutoSize = true;
            this.label_flow.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_flow.Location = new System.Drawing.Point(8, 16);
            this.label_flow.MinimumSize = new System.Drawing.Size(45, 0);
            this.label_flow.Name = "label_flow";
            this.label_flow.Size = new System.Drawing.Size(45, 13);
            this.label_flow.TabIndex = 0;
            this.label_flow.Text = "0.0";
            this.label_flow.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // groupBox7
            // 
            this.groupBox7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox7.Controls.Add(this.label5);
            this.groupBox7.Controls.Add(this.label_density);
            this.groupBox7.Location = new System.Drawing.Point(399, 401);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(96, 40);
            this.groupBox7.TabIndex = 4;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Avg. Desity";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "cars/km";
            // 
            // label_density
            // 
            this.label_density.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_density.AutoSize = true;
            this.label_density.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_density.Location = new System.Drawing.Point(6, 16);
            this.label_density.MinimumSize = new System.Drawing.Size(40, 0);
            this.label_density.Name = "label_density";
            this.label_density.Size = new System.Drawing.Size(40, 13);
            this.label_density.TabIndex = 0;
            this.label_density.Text = "0.0";
            this.label_density.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // TrafficSimGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 453);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TrafficSimGUI";
            this.Text = "TrafficSimGUI";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numeric_cars)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_speedLimit)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton button_play;
        private System.Windows.Forms.ToolStripButton button_pause;
        private System.Windows.Forms.ToolStripButton button_reset;
        private System.Windows.Forms.Label label_simtime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown numeric_cars;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radio_simspeed1;
        private System.Windows.Forms.RadioButton radio_simspeed10;
        private System.Windows.Forms.RadioButton radio_simspeed5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numeric_speedLimit;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_avgv;
        private System.Windows.Forms.RadioButton radio_simspeed30;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton button_save;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label_flow;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label_density;

    }
}

