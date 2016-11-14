using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nelsonj5726_M4HW1
{
    class MobileObject
    {
        private string _Name;
        private int _HP;
        private int _maxHP;
        private int _armor;
        private int _attack;
        private int _damage;
        private bool _canAttack;
        private bool _isDead;
        private int _factionValue;

        public MobileObject()
        {
            _Name = "Error";
            _HP = 0;
            _maxHP = 0;
            _armor = 0;
            _attack = 0;
            _damage = 0;
            _canAttack = false;
            _isDead = false;
        }
        public MobileObject(bool canAttack, bool isDead)
        {
            _Name = "Error";
            _HP = 0;
            _maxHP = 0;
            _armor = 0;
            _attack = 0;
            _damage = 0;
            _canAttack = canAttack;
            _isDead = isDead;
        }
        public MobileObject(string name, int hp, int maxhp, int armor, int attack, int damage, int factionValue, bool canAttack, bool isDead)
        {
            _Name = name;
            _HP = hp;
            _maxHP = maxhp;
            _armor = armor;
            _attack = attack;
            _damage = damage;
            _canAttack = canAttack;
            _isDead = isDead;
        }

        public void OnSpawn()
        {

        }
        public void OnCombatStart()
        {

        }
        public void OnDeath()
        {

        }

        public virtual string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        public virtual int HP
        {
            get { return _HP; }
            set { _HP = value; }
        }
        public virtual int maxHP
        {
            get { return _maxHP; }
            set { _maxHP = value; }
        }
        public virtual int armor
        {
            get { return _armor; }
            set { _armor = value; }
        }
        public virtual int attack
        {
            get { return _attack; }
            set { _attack = value; }
        }
        public virtual int damage
        {
            get { return _damage; }
            set { _damage = value; }
        }
        public virtual int FactionValue
        {
            get { return _factionValue; }
            set { _factionValue = value; }
        }
        public virtual bool canAttack
        {
            get { return _canAttack; }
            set { _canAttack = value; }
        }
        public virtual bool isDead
        {
            get { return _isDead; }
            set { _isDead = value; }
        }
    }
}
