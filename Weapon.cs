using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tavernier
{
    internal class Weapon : Item
    {
        protected string _Name = "None";
        protected int _Atk_Phy = 0;
        protected int _Atk_Elem = 0;
        protected int _Critcal = 0;

        public Weapon() 
        {

        }

        public void chose_Weapon(string weapon_Wanted)
        {
            switch (weapon_Wanted)
            {
                case "Hache Durandil":
                    _Name = weapon_Wanted;
                    _Atk_Phy = 30;
                    _Atk_Elem = 0;
                    break;

                case "Epee eflfique":
                    _Name = weapon_Wanted;
                    _Atk_Phy = 20;
                    _Atk_Elem = 10;
                    break;

                default:
                    break;
            }
        }

        //Get
        public int Atk_Phy { get => _Atk_Phy; set => _Atk_Phy = value; }
    }
}