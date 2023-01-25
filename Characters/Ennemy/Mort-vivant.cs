﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tavernier.Characters.Ennemy
{
    internal class Mort_vivant : Character
    {
        public Mort_vivant()
        {
            _Max_HP = 150;
            _HP = _Max_HP;

            _Max_SP = 80;
            _Phys_Atk = 50;
            _Elem_Atk = 60;

            _Phys_Def = 100;
            _Elem_Def = 50;

            _Accuracy = 95;
            _Critical_Chance = 5;
            _Critical_Dmg = 2;

            _Speed = 40;
        }
    }
}
