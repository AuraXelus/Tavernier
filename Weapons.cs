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
        protected bool _Water_Dmg = false;
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

                    break;

                //2nd arme de Thran
                case "Magmarteau":
                    _Name = weapon_Wanted;

                    break;

                //**********| NINA |**********//

                //1ère arme de Nina
                case "épée elfique":
                    _Name = weapon_Wanted;

                    break;

                //2nd arme de Nina
                case "Lance épineuse":
                    _Name = weapon_Wanted;

                    break;

                //**********| MAGICIENNE |**********//

                //1ère arme de Magicienne
                case "Baguette de sourcier":
                    _Name = weapon_Wanted;

                    break;

                //2nd arme de Magicienne
                case "Baton de feu":
                    _Name = weapon_Wanted;

                    break;
                
                default:
                    break;
            }
        }

        //Get
        //public int Atk_Phy { get => _Damage; set => _Damage = value; }
    }
}