using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tavernier.Characters.Ennemy
{
    internal class Draugr : Player
    {
        public Draugr()
        {
            _Max_HP = 400;
            _HP = _Max_HP;
            _Max_SP = 0;
            _SP = _Max_SP;

            _Phys_Atk = 10;
            _Elem_Atk = 10;

            _Phys_Def = 5;
            _Elem_Def = 5;

            _Accuracy = 90;
            _Critical_Chance = 3;
            _Critical_Puiss = 2;

            _Speed = 80;
        }
    }
}
