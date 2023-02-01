using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tavernier.Characters.Ennemy
{
    internal class Orc : Player
    {
        public Orc()
        {
            _Max_HP = 100;
            _HP = _Max_HP;
            _Max_SP = 0;
            _SP = _Max_SP;

            _Phys_Atk = 30;
            _Elem_Atk = 25;

            _Phys_Def = 5;
            _Elem_Def = 15;

            _Accuracy = 90;
            _Critical_Chance = 3;
            _Critical_Puiss = 2;

            _Speed = 80;

        }
    }
}
