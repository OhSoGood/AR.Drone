using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AR.Drone.Avionics.Apparatus;
using AR.Drone.Client.Command;
using PIDLibrary;

namespace AR.Drone.WinApp
{
    /// <summary>
    /// http://en.wikipedia.org/wiki/PID_controller
    /// maybe the threading implementation is not necessary
    /// </summary>
    public partial class PIDForm : Form
    {
        private PID pid;

        double p, d, i;

        public double I
        {
            get { return i; }
            set { i = value; }
        }

        public double D
        {
            get { return d; }
            set { d = value; }
        }

        public double P
        {
            get { return p; }
            set { p = value; }
        }

        GetDouble pvFunc, spFunc;
        
        public event Action<double> YawUpdateAvailable;

        private SetDouble outFunc;
        public SetDouble OutFunc
        {
            get { return outFunc; }
            set { outFunc = value; }
        }

        private float lastYawUpdate;
        
        private Drone.Client.DroneClient client;
        private Data.Navigation.NavigationData lastNavUpdate;
        public Drone.Client.DroneClient Client
        {
            get { return client; }
            set { client = value; }
        }

        public PIDForm()
        {
            InitializeComponent();

            outFunc += this.UpdateNewYawToDrone;
            pvFunc += this.GetCurrentYaw;
            spFunc += this.GetRefPoint;


            pid = new PID(P = 1, I = 0, D = 0,
                            0, // not shure about these values
                            Math.PI, // --
                            Input.Limits.Yaw.Max, // --
                            Input.Limits.Yaw.Min, // --
                            pvFunc,
                            spFunc,
                            outFunc);
            
        }


        private void UpdateNewYawToDrone(double value)
        {
            // as explained, use this on changing ui elements from another thread
            if (this.InvokeRequired)
            {
                this.Invoke(new Action(() => this.textBox_ControlValue.Text = value.ToString()));
            }

            if (YawUpdateAvailable != null) {
                if (lastYawUpdate < 0)
                    YawUpdateAvailable(value);
                else
                    YawUpdateAvailable(-value);
            }
        }
         
        internal void UpdateNavDataFromDrone(Data.Navigation.NavigationData obj)
        {
            this.lastNavUpdate = obj;

            this.lastYawUpdate = obj.Yaw;

            if (this.InvokeRequired) {
                this.Invoke(new Action(() => {
                    this.textBox_InputFromDrone.Text = obj.Yaw.ToString();
                    this.textBox_Cool.Text = pid.PIDOK ? "Cool" : "uncool";
                    }));
            }
        }

        private double GetRefPoint()
        {
            return double.Parse(this.textBox_FixValue.Text);
        }

        double GetCurrentYaw() 
        {
            return this.lastYawUpdate;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pid.Enable();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pid.Disable();
            this.lastYawUpdate = 0f;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.textBox_FixValue.Text = this.lastYawUpdate.ToString();
        }
    }
}
