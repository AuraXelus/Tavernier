using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Tavernier
{
    public class Nina : Player
    {
        public Nina()
        {
            Name = "Nina";
            _Elem_Type = "Nature";

            _Max_HP = 100;
            _HP = _Max_HP;
            _Max_SP = 80;
            _SP = _Max_SP;

            _Phys_Atk = 40;
            _Elem_Atk = 30;

            _Phys_Def = 10;
            _Elem_Def = 5;

            _Accuracy = 95;
            _Critical_Chance = 4;
            _Critical_Puiss = 2;

            _Speed = 90;

            _Sprite = "                                                                                               .---.    .-'.\r\n                                                                                          ( (-/==^==.  /    ) ))\r\n                                                                                            /|))è é()./   .'\r\n                                                                                           ('-((\\_/( ))..' /\r\n                                                                                            \\ '-;_.-. ) ))\r\n                                                                                             '-(_ _)_\\ ) )).'\r\n                                                                                              / ) (/_ ) \\\r\n                                                                                          (( ( /\\_/\\,/|  ) ))\r\n                                                                                              /  .  '.'.' \r\n                                                                                             (  .\\  . '.___.\r\n                                                                                              \\_| \\  '.___/\r\n                                                                                               \\'._;.___) ";

            _Name_First_Weapon = "Pony chopper";
            _First_Weapon.choseWeapon(_Name_First_Weapon);

            _First_Skill.setSkill("Nina", 1);
            _Second_Skill.setSkill("Nina", 2);
        }
    }
}