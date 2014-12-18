﻿namespace AR.Drone.WinApp
{
    partial class PIDForm
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
            this.textBox_ControlValue = new System.Windows.Forms.TextBox();
            this.textBox_InputFromDrone = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_FixValue = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_Ki = new System.Windows.Forms.TextBox();
            this.textBox_Kp = new System.Windows.Forms.TextBox();
            this.textBox_Kd = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox_Cool = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox_ControlValue
            // 
            this.textBox_ControlValue.Location = new System.Drawing.Point(386, 136);
            this.textBox_ControlValue.Name = "textBox_ControlValue";
            this.textBox_ControlValue.Size = new System.Drawing.Size(100, 20);
            this.textBox_ControlValue.TabIndex = 0;
            // 
            // textBox_InputFromDrone
            // 
            this.textBox_InputFromDrone.Location = new System.Drawing.Point(33, 136);
            this.textBox_InputFromDrone.Name = "textBox_InputFromDrone";
            this.textBox_InputFromDrone.Size = new System.Drawing.Size(100, 20);
            this.textBox_InputFromDrone.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Aktuelles Signal";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(383, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Steuersignal 2 Drone";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(185, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ausgangswert";
            // 
            // textBox_FixValue
            // 
            this.textBox_FixValue.Location = new System.Drawing.Point(188, 136);
            this.textBox_FixValue.Name = "textBox_FixValue";
            this.textBox_FixValue.Size = new System.Drawing.Size(100, 20);
            this.textBox_FixValue.TabIndex = 4;
            this.textBox_FixValue.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "von Drohne";
            // 
            // textBox_Ki
            // 
            this.textBox_Ki.Location = new System.Drawing.Point(156, 242);
            this.textBox_Ki.Name = "textBox_Ki";
            this.textBox_Ki.Size = new System.Drawing.Size(100, 20);
            this.textBox_Ki.TabIndex = 9;
            // 
            // textBox_Kp
            // 
            this.textBox_Kp.Location = new System.Drawing.Point(33, 242);
            this.textBox_Kp.Name = "textBox_Kp";
            this.textBox_Kp.Size = new System.Drawing.Size(100, 20);
            this.textBox_Kp.TabIndex = 8;
            // 
            // textBox_Kd
            // 
            this.textBox_Kd.Location = new System.Drawing.Point(278, 242);
            this.textBox_Kd.Name = "textBox_Kd";
            this.textBox_Kd.Size = new System.Drawing.Size(100, 20);
            this.textBox_Kd.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Kp";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(153, 226);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Ki";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(275, 226);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Kd";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(185, 120);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "am Start festgelegt";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(33, 307);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Enable";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(123, 307);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 15;
            this.button2.Text = "Disable";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(188, 163);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 16;
            this.button3.Text = "Setzen";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox_Cool
            // 
            this.textBox_Cool.Location = new System.Drawing.Point(33, 163);
            this.textBox_Cool.Name = "textBox_Cool";
            this.textBox_Cool.Size = new System.Drawing.Size(100, 20);
            this.textBox_Cool.TabIndex = 17;
            // 
            // PIDForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 342);
            this.Controls.Add(this.textBox_Cool);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_Ki);
            this.Controls.Add(this.textBox_Kp);
            this.Controls.Add(this.textBox_Kd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_FixValue);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_InputFromDrone);
            this.Controls.Add(this.textBox_ControlValue);
            this.Name = "PIDForm";
            this.Text = "PIDForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_ControlValue;
        private System.Windows.Forms.TextBox textBox_InputFromDrone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_FixValue;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_Ki;
        private System.Windows.Forms.TextBox textBox_Kp;
        private System.Windows.Forms.TextBox textBox_Kd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox_Cool;
    }
}