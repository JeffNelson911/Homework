using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nelsonj5726_M4HW1
{
    class Monster : MobileObject
    {      
        public Monster()
            :base()
        {
            canAttack = true;
        }
        public Monster(bool canAttack, bool isDead)
           : base(canAttack, isDead)
        {
            FactionValue = 0;
        }
        public Monster(string name, int hp, int maxhp, int armor, int attack, int damage, int factionValue, bool canAttack, bool isDead)
            : base(name, hp, maxhp, armor, attack, damage, factionValue, canAttack, isDead)
        {
            FactionValue = 0;
        }

    }
}
