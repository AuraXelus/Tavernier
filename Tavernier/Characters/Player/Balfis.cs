using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tavernier;

namespace Tavernier
{
    public class Balfis : Player
    {

        public Balfis() 
        {
            _Name = "Balfis";
            _Elem_Type = "Fire";
            _Lvl = 1;
            _Exp= 0;

            _Max_HP = 100;
            _HP = _Max_HP;
            _Max_SP = 70;
            _SP = _Max_SP;

            _Phys_Atk = 30;
            _Elem_Atk = 25;

            _Phys_Def = 20;
            _Elem_Def = 10;

            _Accuracy = 90;
            _Critical_Chance = 2;
            _Critical_Puiss = 2;

            _Speed = 70;

            _Name_First_Weapon = "Dream crusher";
            _First_Weapon.choseWeapon(_Name_First_Weapon);

            _First_Skill.setSkill("Balfis", 1);
            _Second_Skill.setSkill("Balfis", 2);
        }
    }
}
