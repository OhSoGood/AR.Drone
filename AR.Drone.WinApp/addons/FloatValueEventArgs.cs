using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AR.Drone.WinApp.addons
{
    public class FloatValueChangedEventArgs
    {
        
        /// <summary>
        /// ValueChangedEventArgs
        /// </summary>
        /// <param name="currentValue">The current value of the ProgressBar</param>
        public FloatValueChangedEventArgs(int currentValue)
        {
            this.Value = currentValue;
        }

        /// <summary>
        /// The current value of ProgressBar
        /// </summary>
        public int Value { get; set; }
    }
}
