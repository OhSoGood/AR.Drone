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
            this.flymode = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.StreamLookUp = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // start
            // 
            this.start.Enabled = false;
            this.start.Location = new System.Drawing.Point(239, 241);
            this.start.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.stop.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.listStream.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listStream.Name = "listStream";
            this.listStream.Size = new System.Drawing.Size(159, 225);
            this.listStream.TabIndex = 2;
            this.listStream.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // connect
            // 
            this.connect.Location = new System.Drawing.Point(178, 241);
            this.connect.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.scaleFactor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.scaleFactor.Name = "scaleFactor";
            this.scaleFactor.Size = new System.Drawing.Size(92, 20);
            this.scaleFactor.TabIndex = 4;
            this.scaleFactor.Text = "20";
            this.scaleFactor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.scaleFactor.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // flymode
            // 
            this.flymode.FormattingEnabled = true;
            this.flymode.Items.AddRange(new object[] {
            "progressive",
            "absolute"});
            this.flymode.Location = new System.Drawing.Point(190, 64);
            this.flymode.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.flymode.Name = "flymode";
            this.flymode.Size = new System.Drawing.Size(92, 21);
            this.flymode.TabIndex = 5;
            this.flymode.Text = "progressive";
            this.flymode.SelectedIndexChanged += new System.EventHandler(this.flymode_SelectedIndexChanged);
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
            // lslControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 279);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.StreamLookUp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flymode);
            this.Controls.Add(this.scaleFactor);
            this.Controls.Add(this.connect);
            this.Controls.Add(this.listStream);
            this.Controls.Add(this.stop);
            this.Controls.Add(this.start);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
        private System.Windows.Forms.ComboBox flymode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button StreamLookUp;
        public System.Windows.Forms.Button stop;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}