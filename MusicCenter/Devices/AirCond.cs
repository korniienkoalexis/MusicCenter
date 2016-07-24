using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicCenter
{
    class AirCond : Device, IOn_Off, ITemperature, IDeviceChangeMode
    {
        public AirCond(bool state, string name, AirCondModeChng airmode, Temperature temperature)
            : base(state, name)
        {
            aircond_mode = airmode;
            aircond_temperature = temperature;
        }
        private AirCondModeChng aircond_mode;
        private Temperature aircond_temperature;

        public override void On()
        {
            state = true;
        }
        public override void Off()
        {
            state = false;
        }

        public void UpTemperature()
        {
            aircond_temperature.UpTemperature();
        }

        public void DownTemperature()
        {
            aircond_temperature.DownTemperature();
        }

        public void ChangeMode()
        {
            aircond_mode.ChangeMode();
        }

        public override string Info()
        {

            string state;
            if (this.state)
            {
                state = "ON";
            }
            else
            {
                state = "OFF";
            }
            int temperature = aircond_temperature.GetTemperature();
            string mode = aircond_mode.GetAirCondMode();
            return "AirConditioner name: " + name + " state: " + state + " Temperature: " + temperature + " Mode: " + mode;
        }
    }
}
