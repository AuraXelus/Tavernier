using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tavernier
{
    public class Weapon
    {
        protected string _Name = "None";
        protected int _Phys_Atk = 0;
        protected int _Elem_Atk = 0;

        protected bool _Slash;
        protected bool _Thrust;
        protected bool _Strike;
        protected int _Critcal = 0;

        public Weapon() 
        {

        }

        public void choseWeapon(string weapon_Wanted)
        {
            switch (weapon_Wanted)
            {
                case "Beagener's Axe":
                    _Name = weapon_Wanted;
                    _Phys_Atk = 15;
                    _Elem_Atk = 0;
                    _Slash = true;
                    _Thrust = false;
                    _Strike = false;
                    break;

                case "Epee eflfique":
                    _Name = weapon_Wanted;
                    _Phys_Atk = 20;
                    _Elem_Atk = 10;
                    _Slash = true;
                    _Thrust = false;
                    _Strike = false;
                    break;

                default:
                    break;
            }
        }

        //Get
        public int Phy_Atk { get => _Phys_Atk; set => _Phys_Atk = value; }
        public int Elem_Atk { get => _Elem_Atk; set => _Elem_Atk = value; }

        public bool Slash { get => _Slash; set => _Slash = value; }
        public bool Thrust { get => _Thrust; set => _Thrust = value; }
        public bool Strike { get => _Strike; set => _Strike = value; }


    }
}