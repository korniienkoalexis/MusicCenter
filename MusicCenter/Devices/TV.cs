using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicCenter
{
    class TV : Device, IVolume, ITVChangeChannel, IOn_Off
    {
        public TV(bool state, string name, TVChanneChangel tv_channel, Volume tv_volume)
            : base(state, name)
        {
            tv_numchannel = tv_channel;
            tv_vol = tv_volume;
        }
        public TV(bool state, string name)
            : base(state, name)
        { 

        }

        private TVChanneChangel tv_numchannel;
        private Volume tv_vol;

        public override void On()
        {
            state = true;
        }
        public override void Off()
        {
            state = false;
        }

        public void NextChannal()
        {
            tv_numchannel.NextChannal();
        }

        public void PrevChannel()
        {
            tv_numchannel.PrevChannel();
        }

        public void UpVolume()
        {
            tv_vol.UpVolume();
        }

        public void DownVolume()
        {
            tv_vol.DownVolume();
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
            int volume = tv_vol.GetVolume();
            string channel = tv_numchannel.GetChannel();
            return "TV name: " + name + " state: " + state  + " Volume: " + volume + " Channel: " + channel;
        }
    } 
}
