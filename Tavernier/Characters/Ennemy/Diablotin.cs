using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tavernier.Characters.Ennemy
{
    internal class Diablotin : Character
    {
        public Diablotin()
        {
            _Max_HP = 50;
            _HP = _Max_HP;
            _Max_SP = 0;
            _SP = _Max_SP;

            _Phys_Atk = 0;
            _Elem_Atk = 20;

            _Phys_Def = 15;
            _Elem_Def = 20;

            _Accuracy = 80;
            _Critical_Chance = 3;
            _Critical_Puiss = 2;

            _Speed = 85;
        }
    }
}
