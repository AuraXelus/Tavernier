using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tavernier.Item
{
    internal class Armors : Item
    {
        protected string _Name = "None";

        protected int _Slash_Res = 0;
        protected int _Thrust_Res = 0;
        protected int _Strike_Res = 0;

        protected int _Fire_Res = 0;
        protected int _Water_Res = 0;
        protected int _Nature_Res = 0;

        public Armors()
        {

        }

        public void choose_Armor(string armor_Wanted)
        {
            switch (armor_Wanted)
            {
                //**********| THRAN |**********//

                //Tête
                case "Casque lourd":
                    _Name = armor_Wanted;
                    _Strike_Res = 20;
                    _Fire_Res = 5;
                    break;

                //Torse
                case "Plastron lourd":
                    _Name = armor_Wanted;
                    _Strike_Res = 50;
                    _Fire_Res = 15;
                    break;

                //Jambière
                case "Jambière lourde":
                    _Name = armor_Wanted;
                    _Strike_Res = 30;
                    _Fire_Res = 10;
                    break;

                //**********| NINA |**********//

                //Tête
                case "Capuche sylvestre":
                    _Name = armor_Wanted;
                    _Slash_Res = 10;
                    _Nature_Res = 10;

                    break;

                //Torse
                case "Cuirasse sylvestre":
                    _Name = armor_Wanted;
                    _Slash_Res = 20;
                    _Nature_Res = 20;

                    break;

                //Jambière
                case "Pantalon sylvestre":
                    _Name = armor_Wanted;
                    _Slash_Res = 15;
                    _Nature_Res = 15;

                    break;

                //**********| Benoit |**********//

                //Tête
                case "Capuchon ensorcelée":
                    _Name = armor_Wanted;
                    _Thrust_Res = 5;
                    _Water_Res = 20;

                    break;

                //Torse
                case "Tunique ensorcelée":
                    _Name = armor_Wanted;
                    _Thrust_Res = 15;
                    _Water_Res = 50;

                    break;

                //Jambière
                case "Chausse ensorcelée":
                    _Name = armor_Wanted;
                    _Thrust_Res = 10;
                    _Water_Res = 30;

                    break;

                //**********| Ailphynna |**********//

                //Tête
                case "Bois de cerf":
                    _Name = armor_Wanted;
                    break;

                //Torse
                case "Tunique de Druide":
                    _Name = armor_Wanted;

                    break;

                //Jambière
                case "Braies de Druide":
                    _Name = armor_Wanted;

                    break;

                default:
                    break;
            }
        }
    }
}