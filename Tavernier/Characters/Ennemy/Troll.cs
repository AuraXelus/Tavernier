using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tavernier.Characters.Ennemy
{
    internal class Troll : Character
    {
        public Troll()
        {
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
        }
    }
}
