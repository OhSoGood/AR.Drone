﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LSL;
using AR.Drone.Client.Command;

namespace AR.Drone.WinApp
{
    public partial class lslControl : Form
    {
        public liblsl.StreamInlet inlet;
        float[] sample = new float[1];
        private Drone.Client.DroneClient client;
        private List<string> listItems = new List<string>();
        private liblsl.StreamInfo[] results;
        private float factor = 10;

        public lslControl(Drone.Client.DroneClient client)
        {
            InitializeComponent();
            // wait until an EEG stream shows up
            this.results = liblsl.resolve_stream("type", "EEG");
            for (int i = 0; i < this.results.Count(); i++)
            {
                listItems.Add(this.results[i].name() + " (from " + this.results[i].hostname() + ")");
            }

            listStream.DataSource = listItems;



            this.client = client;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("start");
            float parsedText;
            if (float.TryParse(scaleFactor.Text.Trim(), out parsedText))
            {
                this.factor = parsedText;
                System.Console.WriteLine("Factor is " + this.factor);
            }
            else
            {
                MessageBox.Show("Please insert correct value for scaling factor.");
            }

            flymode.Enabled = false;
            scaleFactor.Enabled = false;
            stop.Enabled = true;
            connect.Enabled = false;
            this.lslTimer.Start();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Console.WriteLine("stop");
            this.lslTimer.Stop();
            connect.Enabled = true;
            start.Enabled = false;
            stop.Enabled = false;
            flymode.Enabled = true;
            scaleFactor.Enabled = true;
        }

        private void lslTimer_Tick(object sender, EventArgs e)
        {
            // read samples
            this.inlet.pull_sample(this.sample);
            System.Console.WriteLine(this.sample[0]);
            if (flymode.SelectedIndex == 0)
            {
                client.Progress(FlightMode.Progressive, pitch: (sample.First() - 1) / this.factor);
            }
            else if (flymode.SelectedIndex == 1)
            {
                client.Progress(FlightMode.AbsoluteControl, pitch: (sample.First() - 1) / this.factor);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            // open an inlet and print some interesting info about the stream (meta-data, etc.)
            this.inlet = new liblsl.StreamInlet(this.results[listStream.SelectedIndex]);
            System.Console.Write(inlet.info().as_xml());
            System.Console.WriteLine("Connected.");
            start.Enabled = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void flymode_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
