using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicCenter
{
    class AirCondModeChng
    {
        private AirCondMode airCondMode;
        public void ChangeMode()
        {
            airCondMode++;
            if ((int)airCondMode >= Enum.GetNames(typeof(MusicCenterMode)).Length)
            {
                airCondMode = 0;
            }
        }

        public string GetAirCondMode()
        {
            return airCondMode.ToString();
        }
    }
}
