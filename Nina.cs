using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Tavernier
{
    internal class Nina : Character
    {
        public Nina()
        {
            _Max_HP = 100;
            _HP = _Max_HP;

            _Max_SP = 80;
            _Phys_Atk = 20;
            _Elem_Atk = 50;

            _Phys_Def = 20;
            _Elem_Def = 20;

            _Accuracy = 90;
            _Critical_Chance = 4;
            _Critical_Dmg = 2;

            _Speed = 90;
        }
    }
}