using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tavernier;

namespace Tavernier
{
    internal class Thran : Character
    {

        public Thran() 
        {
            _Name = "Thran";

            _Max_HP = 100;
            _HP = _Max_HP;
            _Max_SP = 70;
            _SP = _Max_SP;

            _Phys_Atk = 30;
            _Elem_Atk = 50;
            _Phys_Def = 100;
            _Elem_Def = 70;

            _Accuracy = 80;
            _Critical_Chance = 10;
            _Critical_Puiss = 2;
            _Speed = 70;

            _Name_First_Weapon = "Hache Durandil";
            _First_Weapon.chose_Weapon(_Name_First_Weapon);

            _First_Skill.setSkill("Thran", 1);
            _Second_Skill.setSkill("Thran", 2);
        }
    }
}
