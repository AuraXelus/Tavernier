using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tavernier
{
    public class Weapon : Item
    {
        protected string _Name = "None";
        protected int _Phys_Atk = 0;
        protected int _Elem_Atk = 0;
        protected int _Critcal = 0;

        public Weapon() 
        {

        }

        public void chose_Weapon(string weapon_Wanted)
        {
            switch (weapon_Wanted)
            {
                case "Beagener's Axe":
                    _Name = weapon_Wanted;
                    _Phys_Atk = 15;
                    _Elem_Atk = 0;
                    break;

                case "Epee eflfique":
                    _Name = weapon_Wanted;
                    _Phys_Atk = 20;
                    _Elem_Atk = 10;
                    break;

                default:
                    break;
            }
        }

        //Get
        public int Phy_Atk { get => _Phys_Atk; set => _Phys_Atk = value; }
        public int Elem_Atk { get => _Elem_Atk; set => _Elem_Atk = value; }
    }
}