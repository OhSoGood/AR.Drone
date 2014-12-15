using AR.Drone.Client.Configuration;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AR.Drone.WinApp
{
    public partial class ConfigValues : Form
    {
        public ConfigValues()
        {
            InitializeComponent();
        }


        public void UpdateConfigValues(Settings newSettings){
            
            this.settings = newSettings;
            if (InvokeRequired) {

                Invoke(new Action(() =>{
                    //listBox1.DataSource = new BindingSource(settings.Items, null); 
                    //listBox1.DisplayMember = "Value"; 
                    //listBox1.ValueMember = "Key";

                    this.propertyGrid2.SelectedObject = settings.Control;
                    this.propertyGrid1.SelectedObject = settings.General;
                    this.propertyGrid3.SelectedObject = settings.Userbox;
                }));


            }
        }

        public Settings settings { get; set; }
    }
}
