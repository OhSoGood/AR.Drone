﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LSL;

namespace AR.Drone.WinApp
{
    public partial class lslControl : Form
    {
        public liblsl.StreamInlet inlet;
        float[] sample = new float[8];

        public lslControl()
        {
            InitializeComponent();
            // wait until an EEG stream shows up
            liblsl.StreamInfo[] results = liblsl.resolve_stream("type", "EEG");

            // open an inlet and print some interesting info about the stream (meta-data, etc.)
            this.inlet = new liblsl.StreamInlet(results[0]);
            System.Console.Write(inlet.info().as_xml());

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("start");
            this.lslTimer.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Console.WriteLine("stop");
            this.lslTimer.Stop();
        }

        private void lslTimer_Tick(object sender, EventArgs e)
        {
            // read samples
            this.inlet.pull_sample(this.sample);
            System.Console.WriteLine(this.sample);
        }
    }
}
