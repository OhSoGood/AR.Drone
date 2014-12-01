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
            this.SuspendLayout();
            // 
            // start
            // 
            this.start.Enabled = false;
            this.start.Location = new System.Drawing.Point(319, 297);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(75, 23);
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
            this.stop.Location = new System.Drawing.Point(400, 297);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(75, 23);
            this.stop.TabIndex = 1;
            this.stop.Text = "Stop";
            this.stop.UseVisualStyleBackColor = true;
            this.stop.Click += new System.EventHandler(this.button2_Click);
            // 
            // listStream
            // 
            this.listStream.FormattingEnabled = true;
            this.listStream.ItemHeight = 16;
            this.listStream.Location = new System.Drawing.Point(21, 12);
            this.listStream.Name = "listStream";
            this.listStream.Size = new System.Drawing.Size(211, 308);
            this.listStream.TabIndex = 2;
            this.listStream.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // connect
            // 
            this.connect.Location = new System.Drawing.Point(238, 297);
            this.connect.Name = "connect";
            this.connect.Size = new System.Drawing.Size(75, 23);
            this.connect.TabIndex = 3;
            this.connect.Text = "Connect";
            this.connect.UseVisualStyleBackColor = true;
            this.connect.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // scaleFactor
            // 
            this.scaleFactor.Location = new System.Drawing.Point(253, 30);
            this.scaleFactor.Name = "scaleFactor";
            this.scaleFactor.Size = new System.Drawing.Size(121, 22);
            this.scaleFactor.TabIndex = 4;
            this.scaleFactor.Text = "10";
            this.scaleFactor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.scaleFactor.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // flymode
            // 
            this.flymode.FormattingEnabled = true;
            this.flymode.Items.AddRange(new object[] {
            "progressive",
            "absolute"});
            this.flymode.Location = new System.Drawing.Point(253, 72);
            this.flymode.Name = "flymode";
            this.flymode.Size = new System.Drawing.Size(121, 24);
            this.flymode.TabIndex = 5;
            this.flymode.Text = "progressive";
            this.flymode.SelectedIndexChanged += new System.EventHandler(this.flymode_SelectedIndexChanged);
            // 
            // lslControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 343);
            this.Controls.Add(this.flymode);
            this.Controls.Add(this.scaleFactor);
            this.Controls.Add(this.connect);
            this.Controls.Add(this.listStream);
            this.Controls.Add(this.stop);
            this.Controls.Add(this.start);
            this.Name = "lslControl";
            this.Text = "lslControl";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Timer lslTimer;
        private System.Windows.Forms.Button stop;
        private System.Windows.Forms.ListBox listStream;
        private System.Windows.Forms.Button connect;
        private System.Windows.Forms.TextBox scaleFactor;
        private System.Windows.Forms.ComboBox flymode;
    }
}