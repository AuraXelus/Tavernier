using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tavernier
{
    internal class Imp : Enemy
    {
        public Imp() 
        {
            Name = "Imp";
            _Elem_Type = "Fire";

            _Max_HP = 50;
            _HP = _Max_HP;
            _Max_SP = 0;
            _SP = _Max_SP;

            _Phys_Atk = 0;
            _Elem_Atk = 20;

            _Phys_Def = 15;
            _Elem_Def = 20;

            _Accuracy = 80;
            _Critical_Chance = 3;
            _Critical_Puiss = 2;

            _Speed = 85;

            _Sprite = "  /  `\\  /   \\/  \\\r\n  |  _ \\/   .==.==.\r\n  | (   \\  /____\\__\\\r\n   \\ \\      (_()(_()\r\n    \\ \\            '---._\r\n     \\                   \\_\r\n  /\\ |`       (__)________/\r\n /  \\|     /\\___/\r\n|    \\     \\||VV\r\n|     \\     \\|\"\"\"\",\r\n|      \\     ______)";

            _Weakness_Slash = true;
            _Weakness_Thrust = false;
            _Weakness_Strike = false;

            _Weakness_Fire = false;
            _Weakness_Ice = true;
            _Weakness_Nature = false;

            _Exp_Give = 15;
        }
    }
}
