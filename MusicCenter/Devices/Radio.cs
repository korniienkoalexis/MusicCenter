using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicCenter
{
    class Radio : Device , IVolume, IRadioChannel, IOnOff
    {
        public Radio(bool state, string name, Volume radioVolume , RadioChannel radioChannel)
            : base(state, name)
        {
            rVolume = radioVolume;
            rChannel = radioChannel;
        }

        private Volume rVolume;
        private RadioChannel rChannel;
       
       

        public void UpVolume()
        {
            
            rVolume.UpVolume();
        }

        public void DownVolume()
        {

            rVolume.DownVolume();
        }

        public void NextChannal()
        {
            rChannel.NextChannal();
        }

        public void PrevChannel()
        {
            rChannel.PrevChannel();
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
            float channel = rChannel.GetChannel();
            int volume = rVolume.GetVolume();
            return "Radio " + name + ": " + state + " Volume: " + volume + " Channel: " + channel ;
        }
    }
}
