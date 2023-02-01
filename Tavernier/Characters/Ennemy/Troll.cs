using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tavernier.Characters.Ennemy
{
    public class Troll : Character
    {
        public Troll()
        {
            _Max_HP = 150;
            _HP = _Max_HP;
            _Max_SP = 80;
            _SP = _Max_SP;

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
