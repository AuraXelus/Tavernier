using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tavernier.Item
{
    internal class Weapons : Item
    {
        protected string _Name = "None";

        protected int _Phys_Atk = 0;
        protected int _Elem_Atk = 0;
        protected int _Critical_Chance = 0;

        protected bool _Slash_Dmg = false;
        protected bool _Thrust_Dmg = false;
        protected bool _Strike_Dmg = false;

        protected bool _Fire_Dmg = false;
        protected bool _Ice_Dmg = false;
        protected bool _Nature_Dmg = false;

        public Weapons()
        {

        }

        public void choose_Weapon(string weapon_Wanted)
        {
            switch (weapon_Wanted)
            {
                //**********| THRAN |**********//

                //1ère arme de Thran
                case "Marteau de guerre":
                    _Name = weapon_Wanted;

                    _Phys_Atk = 10;

                    _Strike_Dmg = true;

                    break;

                //**********| NINA |**********//

                //1ère arme de Nina
                case "Epée elfique":
                    _Name = weapon_Wanted;

                    _Phys_Atk = 15;

                    _Slash_Dmg = true;

                    break;

                //**********| Benoit |**********//

                //1ère arme de Benoit
                case "Boule à neige":
                    _Name = weapon_Wanted;

                    _Elem_Atk = 20;

                    _Ice_Dmg = true;

                    break;

                //**********| Ailphynna |**********//

                //1ère arme de Ailphynna
                case "Branche de bouleau":
                    _Name = weapon_Wanted;

                    _Elem_Atk = 15;

                    _Nature_Dmg = true;

                    break;
           
                default:
                    break;
            }
        }
    }
}