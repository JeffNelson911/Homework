using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nelsonj5726_M4HW1
{
    class NPC : MobileObject
    {
        private enum faction { EMPIRE = 0, NEUTRAL, STORMCLOAKS = 0 }
        private string joinedFaction;

        public NPC()
            :base()
        {
            FactionValue = 0;
            joinedFaction = faction.NEUTRAL.ToString();
        }

        public NPC(bool canAttack, bool isDead)
           : base(canAttack, isDead)
        {
            FactionValue = 0;
            joinedFaction = faction.NEUTRAL.ToString();
        }
        public NPC(string name, int hp, int maxhp, int armor, int attack, int damage, int factionValue, bool canAttack, bool isDead)
            : base(name, hp, maxhp, armor, attack, damage, factionValue, canAttack, isDead)
        {
            FactionValue = 0;
            joinedFaction = faction.NEUTRAL.ToString();
        }
    }
}
