using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tavernier
{
    internal class Weapons : Item
    {
        protected string _Name = "None";
        protected int _Phys_Atk = 0;
        protected int _Phys_Elem = 0;
        protected int _Critical_Chance = 0;
        protected int _Slash_Dmg = 0;
        protected int _Thrust_Dmg = 0;
        protected int _Strike_Dmg = 0;


        public Weapons()
        {

        }

        public void chose_Weapon(string weapon_Wanted)
        {
            switch (weapon_Wanted)
            {
                case "Marteeau de guerre":
                    _Name = weapon_Wanted;
                    _Phys_Atk = 10;
                    _Phys_Elem = 0;
                    _Critical_Chance = 10;
                    _Slash_Dmg = 0;
                    _Thrust_Dmg = 0;
                    _Strike_Dmg = 40;

                    break;

                case "Epee eflfique":
                    _Name = weapon_Wanted;
                    _Phys_Atk = 20;
                    _Phys_Elem = 10;
                    _Critical_Chance = 10;
                    _Slash_Dmg = 0;
                    _Thrust_Dmg = 0;
                    _Strike_Dmg = 0;
                    break;

                default:
                    break;
            }
        }

        //Get
        public int Atk_Phy { get => _Phys_Atk; set => _Phys_Atk = value; }
    }
}