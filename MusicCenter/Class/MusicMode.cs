using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicCenter
{
    class MusicMode
    {
        private MusicCenterMode musicCenterMode;
        public void ChangeMode()
        {
            musicCenterMode++;
            if ((int)musicCenterMode >= Enum.GetNames(typeof(MusicCenterMode)).Length)
            {
                musicCenterMode = 0;
            }
        }

        public MusicCenterMode GetMode()
        {
            return musicCenterMode;
        }
    }
}
