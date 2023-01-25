using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Tavernier.Characters.Player
{
    internal class Ailphynna : Character
    {
        public Ailphynna()
        {
            _Max_HP = 100;
            _HP = _Max_HP;
            _Max_SP = 100;
            _SP = _Max_SP;

            _Phys_Atk = 20;
            _Elem_Atk = 40;

            _Phys_Def = 20;
            _Elem_Def = 30;

            _Accuracy = 80;
            _Critical_Chance = 3;
            _Critical_Dmg = 2;

            _Speed = 80;
        }
    }
}