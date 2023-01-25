﻿using System;
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
            _Phys_Atk = 30;
            _Elem_Atk = 30;

            _Phys_Def = 50;
            _Elem_Def = 30;

            _Accuracy = 90;
            _Critical_Chance = 2;
            _Critical_Dmg = 2;

            _Speed = 70;
        }
    }
}