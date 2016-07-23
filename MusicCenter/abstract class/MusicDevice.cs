using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicCenter
{
    abstract class MusicDevice
    {
        public bool state;
        public string name;
        public int volumeLevel;
        public MusicDevice(bool state, string name, int volume)
        {
            this.state = state;
            this.name = name;
            this.volumeLevel = volume;
        }
        public abstract void On();
        public abstract void Off();
        public abstract void UpVolume();
        public abstract void DownVolume();
        public abstract string Info();
    }
}
