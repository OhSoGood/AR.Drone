using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AR.Drone.Client;

namespace AR.Drone.WinApp
{
    public partial class DemoPilot : Form
    {
        public DroneClient client;

        public DemoPilot()
        {
            InitializeComponent();
        }

        private void timerCommandRendering_Tick(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.timerCommandRendering.Interval = 30;

            client.FlatTrim();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            client.Land();
        }
    }
}
