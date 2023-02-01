using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tavernier.Characters.Ennemy
{
    internal class Gnolls : Player
    {
        public Gnolls()
        {
            _Max_HP = 100;
            _HP = _Max_HP;
            _Max_SP = 0;
            _SP = _Max_SP;

            _Phys_Atk = 20;
            _Elem_Atk = 10;

            _Phys_Def = 15;
            _Elem_Def = 10;

            _Accuracy = 85;
            _Critical_Chance = 50;
            _Critical_Puiss = 4;

            _Speed = 90;
        }
    }
}
