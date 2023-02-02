using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tavernier
{
    public class Dragon : Enemy
    {
        public Dragon() 
        {
            Name = "Dragon";
            _Elem_Type = "Fire";

            _Max_HP = 800;
            _HP = _Max_HP;
            _Max_SP = 0;
            _SP = _Max_SP;

            _Phys_Atk = 65;
            _Elem_Atk = 40;

            _Phys_Def = 30;
            _Elem_Def = 40;

            _Accuracy = 85;
            _Critical_Chance = 5;
            _Critical_Puiss = 2;

            _Speed = 55;

            _Sprite = "            .==.        .==.\r\n           //`^\\\\      //^`\\\\\r\n          // ^ ^\\(\\__/)/^ ^^\\\\\r\n         //^ ^^ ^/6  6\\ ^^ ^^\\\\\r\n        //^ ^^ ^ ( .. ) ^ ^^^ \\\\\r\n       // ^^ ^/\\//v\"\"v\\\\/\\^ ^ ^\\\\\r\n      // ^^/\\/  / `~~` \\  \\/\\^ ^\\\\\r\n      \\\\^ /    / ,    , \\    \\^ //\r\n       \\\\/    ( (      ) )    \\//\r\n        ^      \\ \\.__./ /      ^\r\n               (((`  ')))";

            _Weakness_Slash = true;
            _Weakness_Thrust = false;
            _Weakness_Strike = false;

            _Weakness_Fire = false;
            _Weakness_Ice = true;
            _Weakness_Nature = false;

            _Exp_Give = 80;
        }
    }
}
