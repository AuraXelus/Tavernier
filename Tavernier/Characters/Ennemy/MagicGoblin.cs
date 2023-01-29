using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tavernier
{
    public class MagicGoblin : Enemy
    {
        public MagicGoblin()
        {
            _Name = "Magic Goblin";
            _Max_HP = 100;
            _HP = _Max_HP;
            _Max_SP = 60;
            _SP = _Max_SP;

            _Phys_Atk = 10;
            _Elem_Atk = 25;

            _Phys_Def = 5;
            _Elem_Def = 40;

            _Accuracy = 70;
            _Critical_Chance = 3;
            _Critical_Puiss = 2;

            _Speed = 70;

            _Weakness_Slash = true;
            _Weakness_Thrust = false;
            _Weakness_Strike = false;

            _Exp_Give = 50;
        }


    }
}
