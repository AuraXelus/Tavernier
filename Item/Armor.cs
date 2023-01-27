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

        protected int _Phys_Def = 0;
        protected int _Elem_Def = 0;

        protected bool _Slash_Dmg = false;
        protected bool _Thrust_Dmg = false;
        protected bool _Strike_Dmg = false;

        protected bool _Fire_Dmg = false;
        protected bool _Ice_Dmg = false;
        protected bool _Nature_Dmg = false;

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

                    //

                    break;

                //Torse
                case "Plastron lourd":
                    _Name = armor_Wanted;

                    //

                    break;

                //Jambière
                case "Jambière lourde":
                    _Name = armor_Wanted;

                    //

                    break;

                //**********| NINA |**********//

                //Tête
                case "Capuche sylvestre":
                    _Name = armor_Wanted;

                    //

                    break;

                //Torse
                case "Cuirasse sylvestre":
                    _Name = armor_Wanted;

                    //

                    break;

                //Jambière
                case "Pantalon sylvestre":
                    _Name = armor_Wanted;

                    //

                    break;

                //**********| Benoit |**********//

                //Tête
                case "Capuchon ensorcelée":
                    _Name = armor_Wanted;

                    //

                    break;

                //Torse
                case "Tunique ensorcelée":
                    _Name = armor_Wanted;

                    //

                    break;

                //Jambière
                case "Chausse ensorcelée":
                    _Name = armor_Wanted;

                    //

                    break;

                //**********| Ailphynna |**********//

                //Tête
                case "Bois de cerf":
                    _Name = armor_Wanted;

                    //

                    break;

                //Torse
                case "Tunique de Druide":
                    _Name = armor_Wanted;

                    //

                    break;

                //Jambière
                case "Braies de Druide":
                    _Name = armor_Wanted;

                    //

                    break;

                default:
                    break;
            }
        }
    }
}