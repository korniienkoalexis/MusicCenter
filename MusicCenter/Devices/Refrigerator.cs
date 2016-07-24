using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicCenter
{
    class Refrigerator : Device, IOn_Off, IDeviceChangeMode, IdoorOpen, IFrostdoorOpen
    {
        
        private bool doorState;
        private bool frostDoorState;
        private bool ligthState;
        private ChangeFrostMode frostmode;

        public Refrigerator(bool state, string name, ChangeFrostMode fros_tmode, bool doorState, bool frostDoorState) 
            : base (state, name)
        {
            frostmode = fros_tmode;
            this.doorState = doorState;
            this.frostDoorState = frostDoorState;
        }

        public override void On()
        {
            state = true;
        }
        public override void Off()
        {
            state = false;
        }

        public void RefrigeratDoorOpen()
        {
            doorState = true;
            if (state)
            {
                ligthState = true;
            }
            else
            {
                ligthState = false;
            }
            doorState = true;

        }

        public void RefrigeratDoorClose()
        {
            doorState = false;
            ligthState = false;
        }

        public void frostDoorStateOpen()
        {
            if (doorState == true)
            {
                frostDoorState = true;
            }
            
        }

        public void frostDoorStateClose()
        {
            if (doorState == true)
            {
                frostDoorState = false;
            }
        }

        public void ChangeMode()
        {
            frostmode.FrostMode();
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
                state = " OFF";
            }


            string doorState;
            if (this.doorState)
            {
                doorState = "Opened";
            }
            else
            {
                doorState = "Closed";
            }


            string ligthState;
            if (this.ligthState)
            {
                ligthState = "ON";
            }
            else
            {
                ligthState = "OFF";
            }

            string frostDoorState;
            if (this.frostDoorState)
            {
                frostDoorState = "Opened";
            }
            else
            {
                frostDoorState = "Closed";
            }

            return "Refregerator name: " + name + " State: " + state + " ,FrostLevel: " + frostmode.GetFrostMode() + " ,Door State: " + doorState + " ,Light: " + ligthState + " ,Frost Door: " + frostDoorState;
        }

    }
}
