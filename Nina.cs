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
            _Max_HP = 70;
            _HP = _Max_HP;

            _Max_SP = 90;
            _Phys_Atk = 85;
            _Elem_Atk = 30;

            _Accuracy = 90;
            _Critical_Chance = 8;
            _Critical_Dmg = 2;

            _Speed = 90;
        }
    }
}