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
                case "Hache de guerre":
                    _Name = weapon_Wanted;

                    _Phys_Atk = 25;

                    _Strike_Dmg = true;

                    break;

                //2nd arme de Thran
                case "Magmarteau":
                    _Name = weapon_Wanted;

                    _Phys_Atk = 10;
                    _Elem_Atk = 10;

                    _Strike_Dmg = true;
                    _Fire_Dmg = true;

                    break;

                //**********| NINA |**********//

                //1ère arme de Nina
                case "épée elfique":
                    _Name = weapon_Wanted;

                    _Phys_Atk = 0;

                    _Slash_Dmg = true;

                    break;

                //2nd arme de Nina
                case "Lance épineuse":
                    _Name = weapon_Wanted;

                    _Phys_Atk = 0;
                    _Elem_Atk = 0;

                    _Thrust_Dmg = true;
                    _Nature_Dmg = true;

                    break;

                //**********| Benoit |**********//

                //1ère arme de Benoit
                case "Orbe de feu":
                    _Name = weapon_Wanted;
                    _Elem_Atk = 25;
                    _Fire_Dmg = true;

                    break;

                //2nd arme de Benoit
                case "Baguette de sourcier":
                    _Name = weapon_Wanted;
                    _Elem_Atk = 40;
                    _Ice_Dmg = true;

                    break;

                //**********| Ailphynna |**********//

                //1ère arme de Ailphynna
                case "Branche de bouleau":
                    _Name = weapon_Wanted;

                    _Elem_Atk = 25;

                    _Nature_Dmg = true;

                    break;

                //2nd arme de Ailphynna
                case "Sapin":
                    _Name = weapon_Wanted;

                    _Elem_Atk = 25;

                    _Nature_Dmg = true;

                    break;

                default:
                    break;
            }
        }

        //Get
        //public int Atk_Phy { get => _Damage; set => _Damage = value; }
    }
}