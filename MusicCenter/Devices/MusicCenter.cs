using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicCenter
{
    class MusicCenter : Device, IVolume, IDeviceChangeMode, IOnOff
    {
        
        public MusicCenter(bool state, string name, Volume musicVolume, RadioChannel radioChannel , ChangeCD cd , MusicMode musicmode)
            : base(state, name)
        {
            mcVolume = musicVolume;
            mcChannel = radioChannel;
            mcChangeCD = cd;
            mcMode = musicmode;
        }

        private Volume mcVolume;
        private RadioChannel mcChannel;
        private ChangeCD mcChangeCD;
        private MusicMode mcMode;

        

        public void UpVolume()
        {

            mcVolume.UpVolume();
        }

        public void DownVolume()
        {

            mcVolume.DownVolume();
        }

        public void NextChannal()
        {
            mcChannel.NextChannal();
        }

        public void PrevChannel()
        {
            mcChannel.PrevChannel();
        }

         public void NextCD()
         {
             mcChangeCD.NextCD();
         }

        public void ChangeMode()
         {
             mcMode.ChangeMode();
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


            float channel = mcChannel.GetChannel();
            int volume = mcVolume.GetVolume();
            int numCD = mcChangeCD.GetCD();

            return "Music Center: " + name + " state: " + state + " mode: " + mcMode.GetMode() + " Volume: " + volume + " Channel: " + channel + " Disk# " + numCD;
        }



    }
}
