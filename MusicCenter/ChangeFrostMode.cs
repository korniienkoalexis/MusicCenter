using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicCenter
{
    class ChangeFrostMode
    {
        private FrostLevel frostMode;
        public void FrostMode()
        {
            frostMode++;
            if ((int)frostMode >= Enum.GetNames(typeof(MusicCenterMode)).Length)
            {
                frostMode = 0;
            }
        }

        public string GetFrostMode()
        {
            return frostMode.ToString();
        }
    }
}
