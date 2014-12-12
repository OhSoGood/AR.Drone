namespace AR.Drone.WinApp
{
    partial class lslControl
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
            this.start = new System.Windows.Forms.Button();
            this.lslTimer = new System.Windows.Forms.Timer(this.components);
            this.stop = new System.Windows.Forms.Button();
            this.listStream = new System.Windows.Forms.ListBox();
            this.connect = new System.Windows.Forms.Button();
            this.scaleFactor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.StreamLookUp = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox_DiscretControl = new System.Windows.Forms.CheckBox();
            this.textBox__highThreshold = new System.Windows.Forms.TextBox();
            this.textBox_lowThreshold = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // start
            // 
            this.start.Enabled = false;
            this.start.Location = new System.Drawing.Point(239, 241);
            this.start.Margin = new System.Windows.Forms.Padding(2);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(56, 19);
            this.start.TabIndex = 0;
            this.start.Text = "Start";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.button1_Click);
            // 
            // lslTimer
            // 
            this.lslTimer.Tick += new System.EventHandler(this.lslTimer_Tick);
            // 
            // stop
            // 
            this.stop.Enabled = false;
            this.stop.Location = new System.Drawing.Point(300, 241);
            this.stop.Margin = new System.Windows.Forms.Padding(2);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(56, 19);
            this.stop.TabIndex = 1;
            this.stop.Text = "Stop";
            this.stop.UseVisualStyleBackColor = true;
            this.stop.Click += new System.EventHandler(this.button2_Click);
            // 
            // listStream
            // 
            this.listStream.FormattingEnabled = true;
            this.listStream.Location = new System.Drawing.Point(16, 10);
            this.listStream.Margin = new System.Windows.Forms.Padding(2);
            this.listStream.Name = "listStream";
            this.listStream.Size = new System.Drawing.Size(159, 225);
            this.listStream.TabIndex = 2;
            this.listStream.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // connect
            // 
            this.connect.Location = new System.Drawing.Point(178, 241);
            this.connect.Margin = new System.Windows.Forms.Padding(2);
            this.connect.Name = "connect";
            this.connect.Size = new System.Drawing.Size(56, 19);
            this.connect.TabIndex = 3;
            this.connect.Text = "Connect";
            this.connect.UseVisualStyleBackColor = true;
            this.connect.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // scaleFactor
            // 
            this.scaleFactor.Location = new System.Drawing.Point(190, 30);
            this.scaleFactor.Margin = new System.Windows.Forms.Padding(2);
            this.scaleFactor.Name = "scaleFactor";
            this.scaleFactor.Size = new System.Drawing.Size(92, 20);
            this.scaleFactor.TabIndex = 4;
            this.scaleFactor.Text = "20";
            this.scaleFactor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.scaleFactor.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(190, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Scaling";
            // 
            // StreamLookUp
            // 
            this.StreamLookUp.Location = new System.Drawing.Point(16, 241);
            this.StreamLookUp.Name = "StreamLookUp";
            this.StreamLookUp.Size = new System.Drawing.Size(75, 23);
            this.StreamLookUp.TabIndex = 7;
            this.StreamLookUp.Text = "Lookup";
            this.StreamLookUp.UseVisualStyleBackColor = true;
            this.StreamLookUp.Click += new System.EventHandler(this.StreamLookUp_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.LargeChange = 1;
            this.trackBar1.Location = new System.Drawing.Point(190, 190);
            this.trackBar1.Maximum = 1;
            this.trackBar1.Minimum = -1;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(166, 45);
            this.trackBar1.TabIndex = 8;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(190, 114);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(166, 20);
            this.textBox1.TabIndex = 9;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(190, 151);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(166, 20);
            this.textBox2.TabIndex = 10;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(190, 56);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(116, 17);
            this.checkBox1.TabIndex = 11;
            this.checkBox1.Text = "Use plain bci value";
            this.checkBox1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox_DiscretControl
            // 
            this.checkBox_DiscretControl.AutoSize = true;
            this.checkBox_DiscretControl.Location = new System.Drawing.Point(16, 283);
            this.checkBox_DiscretControl.Name = "checkBox_DiscretControl";
            this.checkBox_DiscretControl.Size = new System.Drawing.Size(131, 17);
            this.checkBox_DiscretControl.TabIndex = 14;
            this.checkBox_DiscretControl.Text = "Enable Discret Control";
            this.checkBox_DiscretControl.UseVisualStyleBackColor = true;
            // 
            // textBox__highThreshold
            // 
            this.textBox__highThreshold.Location = new System.Drawing.Point(239, 281);
            this.textBox__highThreshold.Name = "textBox__highThreshold";
            this.textBox__highThreshold.Size = new System.Drawing.Size(100, 20);
            this.textBox__highThreshold.TabIndex = 15;
            this.textBox__highThreshold.Text = "1,7";
            // 
            // textBox_lowThreshold
            // 
            this.textBox_lowThreshold.Location = new System.Drawing.Point(239, 316);
            this.textBox_lowThreshold.Name = "textBox_lowThreshold";
            this.textBox_lowThreshold.Size = new System.Drawing.Size(100, 20);
            this.textBox_lowThreshold.TabIndex = 16;
            this.textBox_lowThreshold.Text = "1,3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(178, 287);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "High";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(178, 319);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Low";
            // 
            // lslControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 388);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_lowThreshold);
            this.Controls.Add(this.textBox__highThreshold);
            this.Controls.Add(this.checkBox_DiscretControl);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.StreamLookUp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.scaleFactor);
            this.Controls.Add(this.connect);
            this.Controls.Add(this.listStream);
            this.Controls.Add(this.stop);
            this.Controls.Add(this.start);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "lslControl";
            this.Text = "lslControl";
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Timer lslTimer;
        private System.Windows.Forms.ListBox listStream;
        private System.Windows.Forms.Button connect;
        private System.Windows.Forms.TextBox scaleFactor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button StreamLookUp;
        public System.Windows.Forms.Button stop;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox_DiscretControl;
        private System.Windows.Forms.TextBox textBox__highThreshold;
        private System.Windows.Forms.TextBox textBox_lowThreshold;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}