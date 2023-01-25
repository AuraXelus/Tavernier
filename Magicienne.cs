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
            _Max_HP = 100;
            _HP = _Max_HP;

            _Max_SP = 100;
            _Phys_Atk = 20;
            _Elem_Atk = 50;

            _Phys_Def = 10;
            _Elem_Def = 50;

            _Accuracy = 80;
            _Critical_Chance = 5;
            _Critical_Dmg = 2;

            _Speed = 80;
        }
    }
}