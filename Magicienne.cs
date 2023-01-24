using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Tavernier
{
    internal class Magicienne : Character
    {
        public Magicienne()
        {
            _Max_HP = 60;
            _HP = _Max_HP;

            _Max_SP = 100;
            _Phys_Atk = 30;
            _Elem_Atk = 90;

            _Accuracy = 85;
            _Critical_Chance = 10;
            _Critical_Dmg = 2;

            _Speed = 90;
        }
    }
}