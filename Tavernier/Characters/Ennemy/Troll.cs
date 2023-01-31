using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tavernier
{
    public class Troll : Enemy
    {
        public Troll() 
        {
            Name = "Troll";
            _Elem_Type = "Nature";

            _Max_HP = 150;
            _HP = _Max_HP;
            _Max_SP = 0;
            _SP = _Max_SP;

            _Phys_Atk = 0;
            _Elem_Atk = 60;

            _Phys_Def = 10;
            _Elem_Def = 5;

            _Accuracy = 80;
            _Critical_Chance = 2;
            _Critical_Puiss = 2;

            _Speed = 70;


            _Weakness_Slash = true;
            _Weakness_Thrust = false;
            _Weakness_Strike = false;

            _Weakness_Fire = true;
            _Weakness_Ice = false;
            _Weakness_Nature = false;
        }
    }
}