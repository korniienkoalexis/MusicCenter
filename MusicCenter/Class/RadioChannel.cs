using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicCenter
{
    class RadioChannel
    {
        private float tuneChannel;

        public RadioChannel(float channel)
        {
            tuneChannel = channel; 
        }
        public void NextChannal()
        {
               tuneChannel = tuneChannel + 0.5F;
                if (tuneChannel > 108.5)
                {
                    tuneChannel = 88.0F;
                }
        }

        public void PrevChannel()
        {
                tuneChannel = tuneChannel - 0.5F;
                if (tuneChannel < 88.0)
                {
                    tuneChannel = 108.5F;
                }
        }

        public float GetChannel()
        {
            return tuneChannel;
        }

    }
}
