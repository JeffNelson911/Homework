using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nelsonj5726_M4HW1
{
    class NPC : MobileObject
    {
        private int _factionValue;

        public NPC()
            :base()
        {

        }

        public int FactionValue
        {
            get { return _factionValue; }
            set { _factionValue = value; }
        }

    }
}
