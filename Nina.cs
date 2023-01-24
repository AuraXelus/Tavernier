using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Tavernier
{
    internal class Nina : Character
    {

        public Nina() 
        {
            _Name = "Nina";

            _Max_HP = 80;
            _HP = _Max_HP;
            _Phys_Atk = 80;
            _Phys_Def = 70;
            _Accuracy = 90;
            _Critical_Chance = 10;
            _Critical_Puiss = 2;

            _Max_SP = 90;
            _Elem_Atk = 90;
            _Elem_Def = 95;
            _Speed = 90;

            _Name_First_Weapon = "Epee elfique";
            _First_Weapon.chose_Weapon("Epee elfique");
        }
    }
}
