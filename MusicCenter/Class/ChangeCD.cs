using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicCenter
{
    class ChangeCD
    {
        private int numCD;

        public ChangeCD(int cd)
        {
            numCD = cd;
        }
        public void NextCD()
        {
           numCD++;
           if (numCD > 6)
              {
                 numCD = 1;
              }
                numCD = 0;
        }

        public int GetCD()
        {
            return numCD;
        }
    }
}
