using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tavernier
{
    internal class Draugr : Enemy
    {
        public Draugr() 
        {
            Name = "Draugr";
            _Elem_Type = "Nature";

            _Max_HP = 400;
            _HP = _Max_HP;
            _Max_SP = 0;
            _SP = _Max_SP;

            _Phys_Atk = 20;
            _Elem_Atk = 25;

            _Phys_Def = 5;
            _Elem_Def = 5;

            _Accuracy = 90;
            _Critical_Chance = 3;
            _Critical_Puiss = 2;

            _Speed = 80;

            _Sprite = "     .-.\r\n     (o.o)\r\n      |=|\r\n     __|__\r\n   //.=|=.\\\\\r\n  // .=|=. \\\\\r\n  \\\\ .=|=. //\r\n   \\\\(_=_)//\r\n    (:| |:)\r\n     || ||\r\n     () ()";

            _Weakness_Slash = false;
            _Weakness_Thrust = true;
            _Weakness_Strike = false;

            _Weakness_Fire = true;
            _Weakness_Ice = false;
            _Weakness_Nature = false;

            _Exp_Give = 30;
        }
    }
}
