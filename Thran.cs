using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tavernier
{
    internal class Thran : Character
    {

        public Thran() 
        {
            _Name = "Thran";

            _Max_HP = 100;
            _HP = _Max_HP;
            _Phys_Atk = 70;
            _Phys_Def = 100;
            _Accuracy = 80;
            _Critical_Chance = 10;
            _Critical_Puiss = 2;

            _Max_SP = 70;
            _Elem_Atk = 50;
            _Elem_Def = 70;
            _Speed = 70;

            _Name_First_Weapon = "Hache Durandil";
            _First_Weapon.chose_Weapon(_Name_First_Weapon);
        }
    }
}