namespace AR.Drone.WinApp
{
    partial class ContinousControl
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
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.trackBar_PitchValue = new System.Windows.Forms.TrackBar();
            this.trackBar_RollValue = new System.Windows.Forms.TrackBar();
            this.trackBar_YawValue = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.trackBar_GazValue = new System.Windows.Forms.TrackBar();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox_GazScaling = new System.Windows.Forms.TextBox();
            this.textBox_YawScaling = new System.Windows.Forms.TextBox();
            this.textBox_RollScaling = new System.Windows.Forms.TextBox();
            this.textBox_PitchScaling = new System.Windows.Forms.TextBox();
            this.label_PitchCommand = new System.Windows.Forms.Label();
            this.label_RollCommand = new System.Windows.Forms.Label();
            this.label_GazCommand = new System.Windows.Forms.Label();
            this.label_YawCommand = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_PitchValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_RollValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_YawValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_GazValue)).BeginInit();
            this.SuspendLayout();
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(12, 12);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(94, 17);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Enable control";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // timer1
            // 
            this.timer1.Interval = 30;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // trackBar_PitchValue
            // 
            this.trackBar_PitchValue.Location = new System.Drawing.Point(74, 65);
            this.trackBar_PitchValue.Maximum = 100;
            this.trackBar_PitchValue.Minimum = 1;
            this.trackBar_PitchValue.Name = "trackBar_PitchValue";
            this.trackBar_PitchValue.Size = new System.Drawing.Size(297, 45);
            this.trackBar_PitchValue.TabIndex = 1;
            this.trackBar_PitchValue.Value = 1;
            this.trackBar_PitchValue.Scroll += new System.EventHandler(this.trackBar_PitchScaling_Scroll);
            // 
            // trackBar_RollValue
            // 
            this.trackBar_RollValue.Location = new System.Drawing.Point(74, 116);
            this.trackBar_RollValue.Maximum = 100;
            this.trackBar_RollValue.Minimum = 1;
            this.trackBar_RollValue.Name = "trackBar_RollValue";
            this.trackBar_RollValue.Size = new System.Drawing.Size(297, 45);
            this.trackBar_RollValue.TabIndex = 2;
            this.trackBar_RollValue.Value = 1;
            this.trackBar_RollValue.Scroll += new System.EventHandler(this.trackBar_RollScaling_Scroll);
            // 
            // trackBar_YawValue
            // 
            this.trackBar_YawValue.Location = new System.Drawing.Point(74, 167);
            this.trackBar_YawValue.Maximum = 100;
            this.trackBar_YawValue.Minimum = 1;
            this.trackBar_YawValue.Name = "trackBar_YawValue";
            this.trackBar_YawValue.Size = new System.Drawing.Size(297, 45);
            this.trackBar_YawValue.TabIndex = 3;
            this.trackBar_YawValue.Value = 1;
            this.trackBar_YawValue.Scroll += new System.EventHandler(this.trackBar_YawScaling_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Pitch";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Roll";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Yaw";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Gaz";
            // 
            // trackBar_GazValue
            // 
            this.trackBar_GazValue.Location = new System.Drawing.Point(74, 213);
            this.trackBar_GazValue.Maximum = 100;
            this.trackBar_GazValue.Minimum = 1;
            this.trackBar_GazValue.Name = "trackBar_GazValue";
            this.trackBar_GazValue.Size = new System.Drawing.Size(297, 45);
            this.trackBar_GazValue.TabIndex = 9;
            this.trackBar_GazValue.Value = 1;
            this.trackBar_GazValue.Scroll += new System.EventHandler(this.trackBarGaz_Scroll);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(512, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Command to Drone";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(74, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Value";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(416, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Scaling";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(377, 68);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(13, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "1";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(377, 116);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(13, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "1";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(377, 167);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(13, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "1";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(377, 213);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(13, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "1";
            // 
            // textBox_GazScaling
            // 
            this.textBox_GazScaling.Location = new System.Drawing.Point(419, 213);
            this.textBox_GazScaling.Name = "textBox_GazScaling";
            this.textBox_GazScaling.Size = new System.Drawing.Size(62, 20);
            this.textBox_GazScaling.TabIndex = 27;
            this.textBox_GazScaling.Text = "0,1";
            // 
            // textBox_YawScaling
            // 
            this.textBox_YawScaling.Location = new System.Drawing.Point(419, 167);
            this.textBox_YawScaling.Name = "textBox_YawScaling";
            this.textBox_YawScaling.Size = new System.Drawing.Size(62, 20);
            this.textBox_YawScaling.TabIndex = 26;
            this.textBox_YawScaling.Text = "0,1";
            // 
            // textBox_RollScaling
            // 
            this.textBox_RollScaling.Location = new System.Drawing.Point(419, 116);
            this.textBox_RollScaling.Name = "textBox_RollScaling";
            this.textBox_RollScaling.Size = new System.Drawing.Size(62, 20);
            this.textBox_RollScaling.TabIndex = 25;
            this.textBox_RollScaling.Text = "0,1";
            // 
            // textBox_PitchScaling
            // 
            this.textBox_PitchScaling.Location = new System.Drawing.Point(419, 68);
            this.textBox_PitchScaling.Name = "textBox_PitchScaling";
            this.textBox_PitchScaling.Size = new System.Drawing.Size(62, 20);
            this.textBox_PitchScaling.TabIndex = 24;
            this.textBox_PitchScaling.Text = "0,1";
            // 
            // label_PitchCommand
            // 
            this.label_PitchCommand.AutoSize = true;
            this.label_PitchCommand.Location = new System.Drawing.Point(515, 71);
            this.label_PitchCommand.Name = "label_PitchCommand";
            this.label_PitchCommand.Size = new System.Drawing.Size(13, 13);
            this.label_PitchCommand.TabIndex = 28;
            this.label_PitchCommand.Text = "0";
            // 
            // label_RollCommand
            // 
            this.label_RollCommand.AutoSize = true;
            this.label_RollCommand.Location = new System.Drawing.Point(515, 116);
            this.label_RollCommand.Name = "label_RollCommand";
            this.label_RollCommand.Size = new System.Drawing.Size(13, 13);
            this.label_RollCommand.TabIndex = 29;
            this.label_RollCommand.Text = "0";
            // 
            // label_GazCommand
            // 
            this.label_GazCommand.AutoSize = true;
            this.label_GazCommand.Location = new System.Drawing.Point(515, 216);
            this.label_GazCommand.Name = "label_GazCommand";
            this.label_GazCommand.Size = new System.Drawing.Size(13, 13);
            this.label_GazCommand.TabIndex = 30;
            this.label_GazCommand.Text = "0";
            // 
            // label_YawCommand
            // 
            this.label_YawCommand.AutoSize = true;
            this.label_YawCommand.Location = new System.Drawing.Point(515, 169);
            this.label_YawCommand.Name = "label_YawCommand";
            this.label_YawCommand.Size = new System.Drawing.Size(13, 13);
            this.label_YawCommand.TabIndex = 31;
            this.label_YawCommand.Text = "0";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(321, 11);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(137, 17);
            this.radioButton1.TabIndex = 32;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "radioButtonMapToPitch";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Checked = true;
            this.radioButton2.Location = new System.Drawing.Point(491, 11);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(131, 17);
            this.radioButton2.TabIndex = 33;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "radioButtonMapToRoll";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(112, 11);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(94, 17);
            this.checkBox2.TabIndex = 34;
            this.checkBox2.Text = "Enable control";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // ContinousControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 269);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.label_YawCommand);
            this.Controls.Add(this.label_GazCommand);
            this.Controls.Add(this.label_RollCommand);
            this.Controls.Add(this.label_PitchCommand);
            this.Controls.Add(this.textBox_GazScaling);
            this.Controls.Add(this.textBox_YawScaling);
            this.Controls.Add(this.textBox_RollScaling);
            this.Controls.Add(this.textBox_PitchScaling);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.trackBar_GazValue);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trackBar_YawValue);
            this.Controls.Add(this.trackBar_RollValue);
            this.Controls.Add(this.trackBar_PitchValue);
            this.Controls.Add(this.checkBox1);
            this.Name = "ContinousControl";
            this.Text = "ContinousControl";
            this.Load += new System.EventHandler(this.ContinousControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_PitchValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_RollValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_YawValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_GazValue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TrackBar trackBar_PitchValue;
        private System.Windows.Forms.TrackBar trackBar_RollValue;
        private System.Windows.Forms.TrackBar trackBar_YawValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TrackBar trackBar_GazValue;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox_GazScaling;
        private System.Windows.Forms.TextBox textBox_YawScaling;
        private System.Windows.Forms.TextBox textBox_RollScaling;
        private System.Windows.Forms.TextBox textBox_PitchScaling;
        private System.Windows.Forms.Label label_PitchCommand;
        private System.Windows.Forms.Label label_RollCommand;
        private System.Windows.Forms.Label label_GazCommand;
        private System.Windows.Forms.Label label_YawCommand;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.CheckBox checkBox2;
    }
}