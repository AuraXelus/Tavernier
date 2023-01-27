using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Tavernier.Characters.Player
{
    internal class Laevis : Character
    {
        public Laevis()
        {
            _Max_HP = 100;
            _HP = _Max_HP;
            _Max_SP = 100;
            _SP = _Max_SP;

            _Phys_Atk = 15;
            _Elem_Atk = 50;

            _Phys_Def = 5;
            _Elem_Def = 25;

            _Accuracy = 85;
            _Critical_Chance = 3;
            _Critical_Dmg = 2;

            _Speed = 80;
        }
    }
}