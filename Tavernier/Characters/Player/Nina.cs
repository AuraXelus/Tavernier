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
            _SP = _Max_SP;

            _Phys_Atk = 40;
            _Elem_Atk = 30;

            _Phys_Def = 10;
            _Elem_Def = 5;

            _Accuracy = 95;
            _Critical_Chance = 4;
            _Critical_Puiss = 2;

            _Speed = 90;
        }
    }
}