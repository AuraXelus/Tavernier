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
        protected int _Damage = 0;
        protected int _Critical_Chance = 0;

        protected int _Slash_Dmg = 0;
        protected int _Thrust_Dmg = 0;
        protected int _Strike_Dmg = 0;

        protected int _Fire_Dmg = 0;
        protected int _Water_Dmg = 0;
        protected int _Nature_Dmg = 0;

        public Weapons()
        {

        }

        public void chose_Weapon(string weapon_Wanted)
        {
            switch (weapon_Wanted)
            {
                //**********| THRAN |**********//

                //1ère arme de Thran
                case "Hache de guerre":
                    _Name = weapon_Wanted;
                    _Damage = 25;
                    _Critical_Chance = 3;
                    _Slash_Dmg = 40;
                    break;

                //2nd arme de Thran
                case "Magmarteau":
                    _Name = weapon_Wanted;
                    _Damage = 15;
                    _Critical_Chance = 3;
                    _Strike_Dmg = 30;
                    _Fire_Dmg = 40;
                    break;

                //**********| NINA |**********//

                //1ère arme de Nina
                case "épée elfique":
                    _Name = weapon_Wanted;
                    _Damage = 15;
                    _Critical_Chance = 40;
                    _Slash_Dmg = 20;
                    break;

                //2nd arme de Nina
                case "Lance épineuse":
                    _Name = weapon_Wanted;
                    _Damage = 10;
                    _Critical_Chance = 3;
                    _Thrust_Dmg = 50;
                    _Nature_Dmg = 40;
                    break;

                //**********| MAGICIENNE |**********//

                //1ère arme de Magicienne
                case "Baguette de sourcier":
                    _Name = weapon_Wanted;
                    _Damage = 5;
                    _Critical_Chance = 2;
                    _Water_Dmg = 100;
                    break;

                //2nd arme de Magicienne
                case "Baton de feu":
                    _Name = weapon_Wanted;
                    _Damage = 15;
                    _Critical_Chance = 3;
                    _Fire_Dmg = 80;
                    break;

                default:
                    break;
            }
        }

        //Get
        public int Atk_Phy { get => _Damage; set => _Damage = value; }
    }
}