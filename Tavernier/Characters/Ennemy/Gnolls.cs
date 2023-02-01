using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tavernier
{
    internal class Gnolls : Enemy
    {
        public Gnolls() 
        {
            Name = "Gnolls";
            _Elem_Type = "Ice";

            _Max_HP = 100;
            _HP = _Max_HP;
            _Max_SP = 0;
            _SP = _Max_SP;

            _Phys_Atk = 20;
            _Elem_Atk = 10;

            _Phys_Def = 15;
            _Elem_Def = 10;

            _Accuracy = 85;
            _Critical_Chance = 50;
            _Critical_Puiss = 4;

            _Speed = 90;

            _Sprite = "         .';:;'.\r\n        /_' _' /\\   __\r\n        ;a/ e= J/-'\"  '.\r\n        \\ ~_   (  -'  ( ;_ ,.\r\n         L~\"'_.    -.  \\ ./  )\r\n         ,'-' '-._  _;  )'   (\r\n       .' .'   _.'\")  \\  \\(  |\r\n      /  (  .-'   __\\{`', \\  |\r\n     / .'  /  _.-'   \"  ; /  |\r\n    / /    '-._'-,     / / \\ (\r\n __/ (_    ,;' .-'    / /  /_'-._";

            _Weakness_Slash = false;
            _Weakness_Thrust = false;
            _Weakness_Strike = true;

            _Weakness_Fire = false;
            _Weakness_Ice = false;
            _Weakness_Nature = true;

            _Exp_Give = 25;
        }
    }
}
