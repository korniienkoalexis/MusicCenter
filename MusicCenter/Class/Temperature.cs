using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicCenter
{
    class Temperature
    {
        private int temperature = 17;

        public int GetTemperature()
        {
            return temperature;
        }

        public void UpTemperature()
        {
            temperature++;
            if (temperature > 30)
            {
                temperature = 30;
            }
        }

        public void DownTemperature()
        {
            temperature--;
            if (temperature < 17)
            {
                temperature = 17;
            }
        }
    }
}
