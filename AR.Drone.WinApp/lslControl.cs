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
        private float lastBCIValue;

        private float incomeOffset;
        public float IncomeOffset
        {
            get { return incomeOffset; }
            set {
                Interlocked.Exchange(ref incomeOffset, value);
                }
        }

        private float incomeScale;
        public float IncomeScale
        {
            get { return incomeScale; }
            set { Interlocked.Exchange(ref incomeScale, value); }
        }

        private float upperThreshold;
        public float UpperThreshold
        {
            get { return upperThreshold; }
            set { Interlocked.Exchange(ref upperThreshold, value); }
        }

        private float lowerThreshold;
        public float LowerThreshold
        {
            get { return lowerThreshold; }
            set { Interlocked.Exchange(ref lowerThreshold, value); }
        }


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
            start.Enabled = false;
            stop.Enabled = true;
            connect.Enabled = false;
            backgroundWorker_lslListener.RunWorkerAsync();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Console.WriteLine("stop");
            this.LSLOUTPUT = 0;
            this.backgroundWorker_lslListener.CancelAsync();
            connect.Enabled = true;
            start.Enabled = false;
            stop.Enabled = false;
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
            System.Console.WriteLine("Connected.");
            start.Enabled = true;
        }

        
        private void flymode_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void StreamLookUp_Click(object sender, EventArgs e)
        {
            this.updateStreamList();
        }
         
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        { 
            while (!backgroundWorker_lslListener.CancellationPending) { 
                
                this.inlet.pull_sample(this.sample);

                float plainSample = this.sample.First();

                
                float modSample = 0f;
                // Income value modification

                if (groupBox1.Enabled)
                {

                    modSample = (plainSample + incomeOffset) * incomeScale;
                    
                }

                if (checkBox_Percentage.Checked) {
                    this.LSLOUTPUT = Map(plainSample, 1f, 1.3f, 1.7f, 2f);
                }
                 
                if (checkBox_DiscretControl.Checked)
                {
                    if(plainSample <= LowerThreshold){
                        this.LSLOUTPUT = -1f;
                    }
                    else if (plainSample >= UpperThreshold){
                        this.LSLOUTPUT = 1f;
                    } 
                }
                else 
                {
                    this.LSLOUTPUT = checkBox1.Checked ? plainSample : plainSample * this.factor;
                }


                // don't be scared... its a anonymous function (Lambda expression) submittet to the GUI Thread
                Invoke(
                    new Action(
                        () =>
                        {
                            // only for visuals
                            this.basicProgressBar_Input.Value = (int)(plainSample * 100);
                            this.basicProgressBar1.Value = (int)(modSample * 100);
                            //this.basicProgressBar_DroneControlValue.Value = (int)(this.LSLOUTPUT * 100);
                            this.textBox1.Text = this.LSLOUTPUT.ToString();
                        }), null);
                
            }
        }

        private void checkBox_ScaleIncoming_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.IncomeScale = float.Parse(textBox1.Text);
        }


        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            this.IncomeOffset = float.Parse(textBox3.Text);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBox1.Checked)
            {
                groupBox1.Enabled = true;
            }
            else {
                groupBox1.Enabled = false;
            }

        }

        private void basicProgressBar_Input_DoubleClick(object sender, EventArgs e)
        {

        }

        private float Map ( float value, float lowMinIn, float lowMaxIn, float highMinIn, float highMaxIn )
        { 
            float result = 0.0f;

            if ( value > highMinIn )
            {
                result = ( value - highMinIn ) / ( highMaxIn - highMinIn );
            }
            else if (value < lowMaxIn)
            {
                result = -(value - lowMinIn) / (lowMaxIn - lowMinIn);
            }
            
            return result;
            
        }

        //private float MapFloatToPixelRange(float value, float minIn, float maxIn, float minOut, float maxOut)
        //{ 
        //    if ( )

        //    float result = (maxOut + ((value - minIn) * (maxOut - minOut)) / (maxIn - minIn));

        //    return result;
        //}
    }
}
