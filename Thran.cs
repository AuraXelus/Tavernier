using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tavernier
{
    internal class Thran : Character
    {
        public Thran()
        {
            _Max_HP = 100;
            _HP = _Max_HP;

            _Max_SP = 70;
            _Phys_Atk = 40;
            _Elem_Atk = 30;

            _Accuracy = 80;
            _Critical_Chance = 5;
            _Critical_Dmg = 2;

            _Speed = 70;
        }
    }
}