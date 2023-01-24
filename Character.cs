using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tavernier
{
    internal class Character
    {
        protected int _Max_HP;
        protected int _HP;

        protected int _Phys_Atk;

        protected int _Phys_Def;

        protected int _Accuracy;
        protected int _Critical_Chance;
        protected int _Critical_Dmg;

        protected int _Max_SP;
        protected int _Elem_Atk;
        protected int _Elem_Def;
        protected int _Speed;

        public Character()
        {

        }

        public virtual void attack(Character target)
        {
            target.receveDammage(_Phys_Atk);
        }

        public virtual void receveDammage(int damage)
        {
            _HP -= (damage - _Phys_Def);
        }

        //Get
        public int Max_HP { get => _Max_HP; set => _Max_HP = value; }
        public int HP { get => _HP; set => _HP = value; }
        public int Phys_Atk { get => _Phys_Atk; set => _Phys_Atk = value; }

    }
}