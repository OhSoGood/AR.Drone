using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LSL;
using AR.Drone.Client.Command;
using System.Threading;

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
        private float updateRate = 100;
        public bool connected = false;
        private float lslOutput = 0.0f;

        public float LSLOUTPUT
        {
            get { return lslOutput; }
            set {
                Interlocked.Exchange(ref lslOutput, value);
            }
        }
        

        public event Action<double> LSLValueAvailable;
        private void OnLSLValueAvailable(double value) 
        {
            if (LSLValueAvailable != null) 
            {
                LSLValueAvailable(value);
            }
        }


        public lslControl(Drone.Client.DroneClient client)
        {
            InitializeComponent();
            // wait until an EEG stream shows up

            this.updateStreamList();
            this.client = client;
            
        }

        private void updateStreamList()
        {
            this.results = liblsl.resolve_streams(1);
            listStream.DataSource = null;
            this.listItems.Clear();

            for (int i = 0; i < this.results.Count(); i++)
            {
                listItems.Add(this.results[i].name() + " (from " + this.results[i].hostname() + ")" + " type: " + this.results[i].type());
            }

            listStream.DataSource = listItems;
            listStream.Refresh();
            if(listItems != null && listItems.Count > 0)
                this.listStream.SelectedIndex = 0;
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
             
            
            scaleFactor.Enabled = false;
            start.Enabled = false;
            stop.Enabled = true;
            connect.Enabled = false;
            //this.lslTimer.Start();
            backgroundWorker1.RunWorkerAsync();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Console.WriteLine("stop");
            this.client.Hover();
            //this.lslTimer.Stop();
            this.LSLOUTPUT = 0;
            this.backgroundWorker1.CancelAsync();
            connect.Enabled = true;
            start.Enabled = false;
            stop.Enabled = false;
            
            scaleFactor.Enabled = true;
        }

        private void lslTimer_Tick(object sender, EventArgs e)
        {
            // read samples
            this.inlet.pull_sample(this.sample);

            System.Console.WriteLine("New Sample " + this.sample[0]);
            
            this.textBox1.Text = this.sample[0].ToString();

            float currentPitch = sample.First() / this.factor;
            
            this.textBox2.Text = currentPitch.ToString();
            
            this.LSLOUTPUT = currentPitch;

            this.OnLSLValueAvailable(currentPitch);

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (listStream.SelectedIndex == -1) return;
            // open an inlet and print some interesting info about the stream (meta-data, etc.)
            this.inlet = new liblsl.StreamInlet(this.results[listStream.SelectedIndex]);
            System.Console.Write(inlet.info().as_xml());
            lslTimer.Interval = (int)inlet.info().nominal_srate();

            System.Console.WriteLine("Connected.");
            start.Enabled = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void flymode_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void StreamLookUp_Click(object sender, EventArgs e)
        {
            this.updateStreamList();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            //client.Progress(FlightMode.Progressive, pitch: );

            this.LSLOUTPUT = ((float)trackBar1.Value / float.Parse(this.scaleFactor.Text));

            //if (PitchValueAvailable != null) {
            //    PitchValueAvailable(((float)trackBar1.Value / float.Parse(this.scaleFactor.Text)));
            //}
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        { 
            while (!backgroundWorker1.CancellationPending) { 
                
                this.inlet.pull_sample(this.sample);

                float plainSample = this.sample.First();

                if (checkBox_DiscretControl.Checked)
                {
                    var upperThreshold = float.Parse(textBox__highThreshold.Text);
                    var lowerThreshold = float.Parse(textBox_lowThreshold.Text);

                    this.LSLOUTPUT = plainSample <= lowerThreshold ? -1 : plainSample >= upperThreshold ? 1 : 0;

                }
                else 
                {
                    this.LSLOUTPUT = checkBox1.Checked ? plainSample : plainSample * this.factor;
                }

                Invoke(new Action(() => this.textBox1.Text = this.LSLOUTPUT.ToString()), null);
                
            }
        }
    }
}
