using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tavernier
{
    public class Elizendre_Character : Character
    {
        public Elizendre_Character() 
        {
            Name = "Elizendre";
            _Elem_Type = "Ice";

            _Max_HP = 100;
            _HP = _Max_HP;
            _Max_SP = 100;
            _SP = _Max_SP;

            _Phys_Atk = 25;
            _Elem_Atk = 45;

            _Phys_Def = 15;
            _Elem_Def = 50;

            _Accuracy = 85;
            _Critical_Chance = 5;
            _Critical_Puiss = 2;

            _Speed = 80;

            _Sprite = "                                                                                                     .-----.\r\n                                                                                           \\ ' /   _/    )/\r\n                                                                                          - ( ) -('---''--)\r\n                                                                                           / . \\((()\\^_^/)()\r\n                                                                                            \\\\_\\ (()_)-((()()\r\n                                                                                             '- \\ )/\\._./(()\r\n                                                                                               '/\\/( X   ) \\\r\n                                                                                               (___)|___/ ) \\\r\n                                                                                                    |.#_|(___)\r\n                                                                                                   /\\    \\ ( (_\r\n                                                                                                   \\/\\/\\/\\) \\\\\r\n                                                                                                   | / \\ |";

            _Name_First_Weapon = "Astral flake";
            _First_Weapon.choseWeapon(_Name_First_Weapon);

            _First_Skill.setSkill("Elizendre", 1);
            _Second_Skill.setSkill("Elizendre", 2);
        }
    }
}
