using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicCenter
{
    class TVChanneChangel
    {
        private TVChannelsList numChannel;
       
        public void NextChannal()
        {
            numChannel++;
            if ((int)numChannel >= Enum.GetNames(typeof(TVChannelsList)).Length)
            {
                numChannel = 0;
            }
        }

        public void PrevChannel()
        {     
            if ((int)numChannel >0)
            {
                numChannel--;
            }
        }

        public string GetChannel()
        {
            return numChannel.ToString();
        }

        
    }
}
