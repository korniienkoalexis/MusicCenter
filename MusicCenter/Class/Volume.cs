using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicCenter
{
    class Volume
    {
        private int volumeLevel = 10;

        

         
        public void UpVolume()
        {
                volumeLevel++;
                if (volumeLevel > 100)
                {
                    volumeLevel = 100;
                }
        }

        public void DownVolume()
        {
                volumeLevel--;
                if (volumeLevel < 1)
                {
                    volumeLevel = 0;
                }
        }

        public int GetVolume()
        {
            return volumeLevel;
        }

    }
}
