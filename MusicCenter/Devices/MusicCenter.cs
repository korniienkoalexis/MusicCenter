using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicCenter
{
    class MusicCenter : Device, IVolume, IDeviceChangeMode, IOn_Off
    {
        
        public MusicCenter(bool state, string name, Volume music_volume, RadioChannel radio_channel , ChangeCD cd , MusicMode musicmode)
            : base(state, name)
        {
            mc_Volume = music_volume;
            mr_channel = radio_channel;
            mr_cdchange = cd;
            mr_mode = musicmode;
        }

        private Volume mc_Volume;
        private RadioChannel mr_channel;
        private ChangeCD mr_cdchange;
        private MusicMode mr_mode;

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

            mc_Volume.UpVolume();
        }

        public void DownVolume()
        {

            mc_Volume.DownVolume();
        }

        public void NextChannal()
        {
            mr_channel.NextChannal();
        }

        public void PrevChannel()
        {
            mr_channel.PrevChannel();
        }

         public void NextCD()
         {
             mr_cdchange.NextCD();
         }

        public void ChangeMode()
         {
             mr_mode.ChangeMode();
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


            float channel = mr_channel.GetChannel();
            int volume = mc_Volume.GetVolume();
            int numCD = mr_cdchange.GetCD();

            return "Music Center: " + name + " state: " + state + " mode: " + mr_mode.GetMode() + " Volume: " + volume + " Channel: " + channel + " Disk# " + numCD;
        }



    }
}
