using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicCenter
{
    class TV : Device, IVolume, ITVChangeChannel, IOnOff
    {
        public TV(bool state, string name, TVChanneChangel tvChannel, Volume tvVolume)
            : base(state, name)
        {
            tvNumchannel = tvChannel;
            tvVol = tvVolume;
        }
        public TV(bool state, string name)
            : base(state, name)
        { 

        }

        private TVChanneChangel tvNumchannel;
        private Volume tvVol;

        

        public void NextChannal()
        {
            tvNumchannel.NextChannal();
        }

        public void PrevChannel()
        {
            tvNumchannel.PrevChannel();
        }

        public void UpVolume()
        {
            tvVol.UpVolume();
        }

        public void DownVolume()
        {
            tvVol.DownVolume();
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
            int volume = tvVol.GetVolume();
            string channel = tvNumchannel.GetChannel();
            return "TV name: " + name + " state: " + state  + " Volume: " + volume + " Channel: " + channel;
        }
    } 
}
