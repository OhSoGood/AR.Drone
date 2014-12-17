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
            this.start = new System.Windows.Forms.Button();
            this.stop = new System.Windows.Forms.Button();
            this.listStream = new System.Windows.Forms.ListBox();
            this.connect = new System.Windows.Forms.Button();
            this.scaleFactor = new System.Windows.Forms.TextBox();
            this.StreamLookUp = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.backgroundWorker_lslListener = new System.ComponentModel.BackgroundWorker();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox_DiscretControl = new System.Windows.Forms.CheckBox();
            this.textBox__highThreshold = new System.Windows.Forms.TextBox();
            this.textBox_lowThreshold = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBox_ScaleIncoming = new System.Windows.Forms.CheckBox();
            this.checkBox_Percentage = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox_OffsetTextbox = new System.Windows.Forms.TextBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.basicProgressBar1 = new ProgressBars.Basic.BasicProgressBar();
            this.basicProgressBar_Input = new ProgressBars.Basic.BasicProgressBar();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // start
            // 
            this.start.Enabled = false;
            this.start.Location = new System.Drawing.Point(179, 241);
            this.start.Margin = new System.Windows.Forms.Padding(2);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(77, 25);
            this.start.TabIndex = 0;
            this.start.Text = "Start";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.button1_Click);
            // 
            // stop
            // 
            this.stop.Enabled = false;
            this.stop.Location = new System.Drawing.Point(179, 270);
            this.stop.Margin = new System.Windows.Forms.Padding(2);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(78, 25);
            this.stop.TabIndex = 1;
            this.stop.Text = "Stop";
            this.stop.UseVisualStyleBackColor = true;
            this.stop.Click += new System.EventHandler(this.button2_Click);
            // 
            // listStream
            // 
            this.listStream.FormattingEnabled = true;
            this.listStream.Location = new System.Drawing.Point(16, 35);
            this.listStream.Margin = new System.Windows.Forms.Padding(2);
            this.listStream.Name = "listStream";
            this.listStream.Size = new System.Drawing.Size(159, 199);
            this.listStream.TabIndex = 2;
            this.listStream.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // connect
            // 
            this.connect.Location = new System.Drawing.Point(17, 241);
            this.connect.Margin = new System.Windows.Forms.Padding(2);
            this.connect.Name = "connect";
            this.connect.Size = new System.Drawing.Size(158, 23);
            this.connect.TabIndex = 3;
            this.connect.Text = "Connect";
            this.connect.UseVisualStyleBackColor = true;
            this.connect.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // scaleFactor
            // 
            this.scaleFactor.Location = new System.Drawing.Point(6, 99);
            this.scaleFactor.Margin = new System.Windows.Forms.Padding(2);
            this.scaleFactor.Name = "scaleFactor";
            this.scaleFactor.Size = new System.Drawing.Size(99, 20);
            this.scaleFactor.TabIndex = 4;
            this.scaleFactor.Text = "20";
            this.scaleFactor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.scaleFactor.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // StreamLookUp
            // 
            this.StreamLookUp.Location = new System.Drawing.Point(16, 8);
            this.StreamLookUp.Name = "StreamLookUp";
            this.StreamLookUp.Size = new System.Drawing.Size(159, 23);
            this.StreamLookUp.TabIndex = 7;
            this.StreamLookUp.Text = "Lookup";
            this.StreamLookUp.UseVisualStyleBackColor = true;
            this.StreamLookUp.Click += new System.EventHandler(this.StreamLookUp_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(663, 79);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(75, 26);
            this.textBox1.TabIndex = 9;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(474, 84);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(131, 20);
            this.textBox2.TabIndex = 10;
            // 
            // backgroundWorker_lslListener
            // 
            this.backgroundWorker_lslListener.WorkerSupportsCancellation = true;
            this.backgroundWorker_lslListener.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(263, 10);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(116, 17);
            this.checkBox1.TabIndex = 11;
            this.checkBox1.Text = "Use plain bci value";
            this.checkBox1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox_DiscretControl
            // 
            this.checkBox_DiscretControl.AutoSize = true;
            this.checkBox_DiscretControl.Location = new System.Drawing.Point(474, 146);
            this.checkBox_DiscretControl.Name = "checkBox_DiscretControl";
            this.checkBox_DiscretControl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBox_DiscretControl.Size = new System.Drawing.Size(131, 17);
            this.checkBox_DiscretControl.TabIndex = 14;
            this.checkBox_DiscretControl.Text = "Enable Discret Control";
            this.checkBox_DiscretControl.UseVisualStyleBackColor = true;
            // 
            // textBox__highThreshold
            // 
            this.textBox__highThreshold.Location = new System.Drawing.Point(505, 170);
            this.textBox__highThreshold.Name = "textBox__highThreshold";
            this.textBox__highThreshold.Size = new System.Drawing.Size(100, 20);
            this.textBox__highThreshold.TabIndex = 15;
            this.textBox__highThreshold.Text = "1,7";
            // 
            // textBox_lowThreshold
            // 
            this.textBox_lowThreshold.Location = new System.Drawing.Point(505, 207);
            this.textBox_lowThreshold.Name = "textBox_lowThreshold";
            this.textBox_lowThreshold.Size = new System.Drawing.Size(100, 20);
            this.textBox_lowThreshold.TabIndex = 16;
            this.textBox_lowThreshold.Text = "1,3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(472, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "High";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(472, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Low";
            // 
            // checkBox_ScaleIncoming
            // 
            this.checkBox_ScaleIncoming.AutoSize = true;
            this.checkBox_ScaleIncoming.Location = new System.Drawing.Point(6, 79);
            this.checkBox_ScaleIncoming.Name = "checkBox_ScaleIncoming";
            this.checkBox_ScaleIncoming.Size = new System.Drawing.Size(99, 17);
            this.checkBox_ScaleIncoming.TabIndex = 20;
            this.checkBox_ScaleIncoming.Text = "Scale Incoming";
            this.checkBox_ScaleIncoming.UseVisualStyleBackColor = true;
            this.checkBox_ScaleIncoming.CheckedChanged += new System.EventHandler(this.checkBox_ScaleIncoming_CheckedChanged);
            // 
            // checkBox_Percentage
            // 
            this.checkBox_Percentage.AutoSize = true;
            this.checkBox_Percentage.Location = new System.Drawing.Point(475, 110);
            this.checkBox_Percentage.Name = "checkBox_Percentage";
            this.checkBox_Percentage.Size = new System.Drawing.Size(153, 17);
            this.checkBox_Percentage.TabIndex = 21;
            this.checkBox_Percentage.Text = "Enable Percentage Control";
            this.checkBox_Percentage.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox_OffsetTextbox);
            this.groupBox1.Controls.Add(this.checkBox3);
            this.groupBox1.Controls.Add(this.scaleFactor);
            this.groupBox1.Controls.Add(this.checkBox_ScaleIncoming);
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(257, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(121, 132);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Modification";
            // 
            // textBox_OffsetTextbox
            // 
            this.textBox_OffsetTextbox.Location = new System.Drawing.Point(6, 39);
            this.textBox_OffsetTextbox.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_OffsetTextbox.Name = "textBox_OffsetTextbox";
            this.textBox_OffsetTextbox.Size = new System.Drawing.Size(99, 20);
            this.textBox_OffsetTextbox.TabIndex = 21;
            this.textBox_OffsetTextbox.Text = "0";
            this.textBox_OffsetTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox_OffsetTextbox.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(6, 19);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(74, 17);
            this.checkBox3.TabIndex = 22;
            this.checkBox3.Text = "Add offset";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(384, 12);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(75, 20);
            this.textBox3.TabIndex = 25;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(181, 10);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(75, 20);
            this.textBox4.TabIndex = 26;
            // 
            // basicProgressBar1
            // 
            this.basicProgressBar1.BackColor = System.Drawing.Color.DarkGray;
            this.basicProgressBar1.Font = new System.Drawing.Font("Consolas", 10.25F);
            this.basicProgressBar1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.basicProgressBar1.Location = new System.Drawing.Point(384, 35);
            this.basicProgressBar1.Maximum = 200;
            this.basicProgressBar1.Minimum = 100;
            this.basicProgressBar1.Name = "basicProgressBar1";
            this.basicProgressBar1.Size = new System.Drawing.Size(75, 199);
            this.basicProgressBar1.TabIndex = 24;
            this.basicProgressBar1.Text = "basicProgressBar1";
            // 
            // basicProgressBar_Input
            // 
            this.basicProgressBar_Input.BackColor = System.Drawing.Color.DarkGray;
            this.basicProgressBar_Input.Font = new System.Drawing.Font("Consolas", 10.25F);
            this.basicProgressBar_Input.ForeColor = System.Drawing.Color.DodgerBlue;
            this.basicProgressBar_Input.Location = new System.Drawing.Point(181, 35);
            this.basicProgressBar_Input.Maximum = 200;
            this.basicProgressBar_Input.Minimum = 100;
            this.basicProgressBar_Input.Name = "basicProgressBar_Input";
            this.basicProgressBar_Input.Size = new System.Drawing.Size(75, 199);
            this.basicProgressBar_Input.TabIndex = 19;
            this.basicProgressBar_Input.Text = "basicProgressBar1";
            this.basicProgressBar_Input.DoubleClick += new System.EventHandler(this.basicProgressBar_Input_DoubleClick);
            // 
            // lslControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 388);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.basicProgressBar1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.checkBox_Percentage);
            this.Controls.Add(this.basicProgressBar_Input);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_lowThreshold);
            this.Controls.Add(this.textBox__highThreshold);
            this.Controls.Add(this.checkBox_DiscretControl);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.StreamLookUp);
            this.Controls.Add(this.connect);
            this.Controls.Add(this.listStream);
            this.Controls.Add(this.stop);
            this.Controls.Add(this.start);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "lslControl";
            this.Text = "lslControl";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button start;
        private System.Windows.Forms.ListBox listStream;
        private System.Windows.Forms.Button connect;
        private System.Windows.Forms.TextBox scaleFactor;
        private System.Windows.Forms.Button StreamLookUp;
        public System.Windows.Forms.Button stop;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.ComponentModel.BackgroundWorker backgroundWorker_lslListener;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox_DiscretControl;
        private System.Windows.Forms.TextBox textBox__highThreshold;
        private System.Windows.Forms.TextBox textBox_lowThreshold;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private ProgressBars.Basic.BasicProgressBar basicProgressBar_Input;
        private System.Windows.Forms.CheckBox checkBox_ScaleIncoming;
        private System.Windows.Forms.CheckBox checkBox_Percentage;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox_OffsetTextbox;
        private System.Windows.Forms.CheckBox checkBox3;
        private ProgressBars.Basic.BasicProgressBar basicProgressBar1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
    }
}