using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nelsonj5726_M4HW1
{
    class Player : MobileObject
    {
        private string joinedFaction;
        public enum faction { EMPIRE = 0, NEUTRAL = 0, STORMCLOAKS = 0 }
        public Player()
            :base()
        {
            joinedFaction = faction.NEUTRAL.ToString();
        }

        public int getFaction(faction faction)
        {
            return (int)faction;
        }
        public void updateFaction(faction faction, int value)
        {
            faction += value;
        }




    }
}
