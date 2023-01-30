using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tavernier
{
    internal class Goblin : Enemy
    {
        public Goblin() 
        {
            Name = "Goblin";
            _Elem_Type = "Nature";

            _Max_HP = 85;
            _HP = _Max_HP;
            _Max_SP = 0;
            _SP = _Max_SP;

            _Phys_Atk = 30;
            _Elem_Atk = 50;

            _Phys_Def = 10;
            _Elem_Def = 5;

            _Accuracy = 85;
            _Critical_Chance = 3;
            _Critical_Puiss = 2;

            _Speed = 80;


            _Weakness_Slash = false;
            _Weakness_Thrust = false;
            _Weakness_Strike = true;

            _Weakness_Fire = true;
            _Weakness_Ice = false;
            _Weakness_Nature = false;
        }
    }
}
