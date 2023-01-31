using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tavernier
{
    public class Laevis : Player
    {
        public Laevis() 
        {
            Name = "Laevis";
            _Elem_Type = "Nature";

            _Max_HP = 100;
            _HP = _Max_HP;
            _Max_SP = 100;
            _SP = _Max_SP;

            _Phys_Atk = 15;
            _Elem_Atk = 50;

            _Phys_Def = 5;
            _Elem_Def = 25;

            _Accuracy = 85;
            _Critical_Chance = 3;
            _Critical_Puiss = 2;

            _Speed = 80;

            _Name_First_Weapon = "Wooden stick";
            _First_Weapon.choseWeapon(_Name_First_Weapon);

            _First_Skill.setSkill("Laevis", 1);
            _Second_Skill.setSkill("Laevis", 2);
        }
    }
}
