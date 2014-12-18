using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.DirectX.DirectInput;
using AR.Drone.Client.Configuration;
using System.Threading;

namespace AR.Drone.WinApp
{
    public partial class ContinousControl : Form
    {
        private Drone.Client.DroneClient client;
        public Drone.Client.DroneClient Client
        {
            get { return client; }
            set { client = value; }
        }

        public lslControl lslControl { get; set; }

        public PIDForm pidControl { get; set; }

        private float currentPitch;
        private float currentYaw;

        private float incomingYaw;
        public float IncomingYaw
        {
            get { return incomingYaw; }
            set { Interlocked.Exchange(ref incomingYaw, value); }
        }

        private float currentRoll;
        private float currentGaz;
        
        public ContinousControl()
        {
            InitializeComponent();
        }

        public void UpdatePitch(double newPitch) 
        {
             this.currentRoll = (float)newPitch;   
        }

        /// <summary>
        /// Reset the state to avoid sending the same state twice
        /// </summary>
        private void ClearLastState()
        {
            this.currentPitch = 0.0f;
            this.currentGaz = 0.0f;
            this.currentRoll = 0.0f;
            this.currentYaw = 0.0f;
            this.IncomingYaw = 0.0f;
        }

        private void UpdateKeyboardInput()
        {
            var keyboardState = this.keyboard.GetCurrentKeyboardState();

            if (keyboardState[Key.UpArrow]) this.currentPitch -= 1;

            if (keyboardState[Key.DownArrow]) this.currentPitch += 1;

            if (keyboardState[Key.RightArrow]) this.currentRoll += 1;

            if (keyboardState[Key.LeftArrow]) this.currentRoll -= 1;

            if (keyboardState[Key.W]) this.currentGaz += 1;

            if (keyboardState[Key.S]) this.currentGaz -= 1;

            if (keyboardState[Key.D]) this.currentYaw += 1;

            if (keyboardState[Key.A]) this.currentYaw -= 1;

        }      

        private void ApplyValueAndScaling()
        {
            var pitchValue = trackBar_PitchValue.Value;
            var pitchScaling = float.Parse(textBox_PitchScaling.Text);
            this.currentPitch *= pitchValue * pitchScaling;
            
            this.currentRoll *= trackBar_RollValue.Value * float.Parse(textBox_RollScaling.Text);
            this.currentYaw *= trackBar_YawValue.Value * float.Parse(textBox_YawScaling.Text);
            this.currentGaz *= trackBar_GazValue.Value * float.Parse(textBox_GazScaling.Text);
        }

        internal void UpdateOnNavDataUpdate(Data.Navigation.NavigationData obj)
        {
            this.IncomingYaw = obj.Yaw;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            UpdateYawCorrection();

            if (lslControl != null) {                 

                if (radioButton1.Checked)
                {
                    this.currentPitch = this.lslControl.LSLOUTPUT;
                }
                else if (radioButton2.Checked) 
                {
                    this.currentRoll = this.lslControl.LSLOUTPUT;
                }
            }

            UpdateKeyboardInput();

            ApplyValueAndScaling();
             
            this.label_PitchCommand.Text = this.currentPitch.ToString();
            this.label_RollCommand.Text = this.currentRoll.ToString();
            this.label_YawCommand.Text = this.currentYaw.ToString();
            this.label_GazCommand.Text = this.currentGaz.ToString();

            UpdateDroneControl();
        }

        private void UpdateYawCorrection()
        {
            if (!this.checkBox2.Checked)
            {

                if (this.IncomingYaw > 0)
                {
                    this.currentYaw = 1;
                }
                else if (this.IncomingYaw < 0)
                {
                    this.currentYaw = -1;
                }
                else
                {
                    this.currentYaw = 0;
                }

            }
            else this.currentYaw = 0;
        }

        public void UpdateDroneControl()
        {
            if (this.Visible && checkBox1.Checked)
            {
                if(this.currentGaz == 0 && 
                    this.currentPitch == 0 &&
                    this.currentRoll == 0 &&
                    this.currentYaw == 0 &&
                    this.currentGaz == 0) {

                    ClearLastState();
                    // Avoid flooding the drone with nonsense commands
                    // if a hover command has been send, there is no need for a second one
                    if(!hoverAlreadySend) client.Hover();
                        this.hoverAlreadySend = true;
                    }

                else {
                    this.hoverAlreadySend = false;

                        client.Progress(
                            Drone.Client.Command.FlightMode.Progressive,
                            roll: currentRoll,
                            pitch: currentPitch,
                            yaw: currentYaw,
                            gaz: currentGaz);

                    ClearLastState();
                }
            }
        }
        
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            this.timer1.Enabled = checkBox1.Checked;
            this.trackBar_GazValue.Enabled = !timer1.Enabled;
            this.trackBar_PitchValue.Enabled = !timer1.Enabled;
            this.trackBar_RollValue.Enabled = !timer1.Enabled;
            this.trackBar_YawValue.Enabled = !timer1.Enabled;
            this.textBox_GazScaling.Enabled = !timer1.Enabled;
            this.textBox_PitchScaling.Enabled = !timer1.Enabled;
            this.textBox_YawScaling.Enabled = !timer1.Enabled;
            this.textBox_RollScaling.Enabled = !timer1.Enabled;
            this.radioButton1.Enabled = !timer1.Enabled;
            this.radioButton2.Enabled = !timer1.Enabled;
        }

        private Device keyboard;
        
        private void ContinousControl_Load(object sender, EventArgs e)
        {
            this.ConnectToDirectInputKeyboard();

        }

        private void ConnectToDirectInputKeyboard()
        {

            DeviceList keyboardControllerList = Manager.GetDevices(DeviceClass.Keyboard, EnumDevicesFlags.AttachedOnly);
            for (int i = 0; i < keyboardControllerList.Count; i++)
            {
                keyboardControllerList.MoveNext();
                DeviceInstance deviceInstance = (DeviceInstance)keyboardControllerList.Current;

                keyboard = new Device(deviceInstance.InstanceGuid);
            }

            keyboard.SetCooperativeLevel(this.Handle, CooperativeLevelFlags.NonExclusive | CooperativeLevelFlags.Background);
            keyboard.SetDataFormat(DeviceDataFormat.Keyboard);
            keyboard.Acquire();
        }

        private void trackBar_PitchScaling_Scroll(object sender, EventArgs e)
        {
            this.label8.Text = (sender as TrackBar).Value.ToString();
        }

        private void trackBar_RollScaling_Scroll(object sender, EventArgs e)
        {
            this.label9.Text = (sender as TrackBar).Value.ToString();
        }

        private void trackBar_YawScaling_Scroll(object sender, EventArgs e)
        {
            this.label10.Text = (sender as TrackBar).Value.ToString();
        }

        private void trackBarGaz_Scroll(object sender, EventArgs e)
        {
            this.label11.Text = (sender as TrackBar).Value.ToString();
        }



        public bool hoverAlreadySend { get; set; }

        private void button1_Click(object sender, EventArgs e)
        {
            var configuration = new Settings();
            configuration.Detect.Type = 10;
            client.Send(configuration);
        }


        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

    }
}
