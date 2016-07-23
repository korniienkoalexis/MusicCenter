using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicCenter
{
    class Radio_2 : Device , IVolume, IRadioChannel, IOn_Off
    {
        public Radio_2(bool state, string name, Volume radio_volume , RadioChannel radio_channel)
            : base(state, name)
        {
            r_Volume = radio_volume;
            r_channel = radio_channel;
        }

        private Volume r_Volume;
        private RadioChannel r_channel;
       
        public override void On()
        {
            state = true;
        }
        public override void Off()
        {
            state = false;
        }

        public void UpVolume()
        {
            
            r_Volume.UpVolume();
        }

        public void DownVolume()
        {

            r_Volume.DownVolume();
        }

        public void NextChannal()
        {
            r_channel.NextChannal();
        }

        public void PrevChannel()
        {
            r_channel.PrevChannel();
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
            float channel = r_channel.GetChannel();
            int volume = r_Volume.GetVolume();
            return "Radio " + name + ": " + state + " Volume: " + volume + " Channel: " + channel ;
        }
    }
}
