using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tavernier
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

        public void chose_Armor(string armor_Wanted)
        {
            switch (armor_Wanted)
            {
                //**********| THRAN |**********//

                //Tête
                case "Casque lourd":
                    _Name = armor_Wanted;
                    break;

                //Torse
                case "Plastron lourd":
                    _Name = armor_Wanted;
                    break;

                //Jambière
                case "Jambière lourde":
                    _Name = armor_Wanted;
                    break;

                //**********| NINA |**********//

                //Tête
                case "Capuche sylvestre":
                    _Name = armor_Wanted;
         
                    break;

                //Torse
                case "Cuirasse sylvestre":
                    _Name = armor_Wanted;
                   
                    break;

                //Jambière
                case "Pantalon sylvestre":
                    _Name = armor_Wanted;
                   
                    break;

                //**********| MAGICIENNE |**********//

                //Tête
                case "Capuchon ensorcelée":
                    _Name = armor_Wanted;
                  
                    break;

                //Torse
                case "Tunique ensorcelée":
                    _Name = armor_Wanted;
                   
                    break;

                //Jambière
                case "Chausse ensorcelée":
                    _Name = armor_Wanted;
                  
                    break;

                default:
                    break;
            }
        }
    }
}