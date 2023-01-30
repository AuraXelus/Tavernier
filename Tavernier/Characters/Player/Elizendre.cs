using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tavernier
{
    public class Elizendre : Player
    {
        public Elizendre() 
        {
            Name = "Elizendre";
            _Elem_Type = "Ice";

            _Max_HP = 100;
            _HP = _Max_HP;
            _Max_SP = 100;
            _SP = _Max_SP;

            _Phys_Atk = 25;
            _Elem_Atk = 45;

            _Phys_Def = 15;
            _Elem_Def = 50;

            _Accuracy = 85;
            _Critical_Chance = 5;
            _Critical_Puiss = 2;

            _Speed = 80;
        }
    }
}
