using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tavernier
{
    internal class Ogre : Enemy
    {
        public Ogre() 
        {
            Name = "Ogre";
            _Elem_Type = "Ice";

            _Max_HP = 250;
            _HP = _Max_HP;
            _Max_SP = 0;
            _SP = _Max_SP;

            _Phys_Atk = 35;
            _Elem_Atk = 30;

            _Phys_Def = 5;
            _Elem_Def = 5;

            _Accuracy = 90;
            _Critical_Chance = 2;
            _Critical_Puiss = 2;

            _Speed = 70;


            _Weakness_Slash = false;
            _Weakness_Thrust = true;
            _Weakness_Strike = false;

            _Weakness_Fire = false;
            _Weakness_Ice = false;
            _Weakness_Nature = true;
        }
    }
}
