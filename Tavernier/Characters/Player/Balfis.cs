using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tavernier.Characters.Player
{
    internal class Balfis : Player
    {
        public Balfis()
        {
            _Max_HP = 100;
            _HP = _Max_HP;
            _Max_SP = 70;
            _SP = _Max_SP;

            _Phys_Atk = 30;
            _Elem_Atk = 25;

            _Phys_Def = 20;
            _Elem_Def = 10;

            _Accuracy = 90;
            _Critical_Chance = 2;
            _Critical_Puiss = 2;

            _Speed = 70;
        }
    }
}