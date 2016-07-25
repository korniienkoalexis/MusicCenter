using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicCenter
{
   abstract class Device : IOnOff
    {
        //public.public bool state;
        //public string name;

        public string name { get; set; }
        public bool state { get; set; }
        public Device(bool state, string name)
        {
            this.state = state;
            this.name = name;
        }
        public void On()
        {
            state = true;
        }
        public void Off()
        {
            state = false;
        }
        public abstract string Info();
    }
}
