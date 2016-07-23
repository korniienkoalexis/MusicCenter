using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicCenter
{
   abstract class Device
    {
        public bool state;
        public string name;
        public Device(bool state, string name)
        {
            this.state = state;
            this.name = name;
        }
        public abstract void On();
        public abstract void Off();
        public abstract string Info();
    }
}
