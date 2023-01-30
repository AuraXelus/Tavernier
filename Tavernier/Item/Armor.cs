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

        public Armors()
        {

        }

        public void choose_Armor(string armor_Wanted)
        {
            switch (armor_Wanted)
            {
                //**********| THRAN |**********//
             
                //Torse
                case "Plastron lourd":
                    _Name = armor_Wanted;

                    _Phys_Def = 10;

                    break;

                //**********| NINA |**********//

                //Tête
                case "Capuche sylvestre":
                    _Name = armor_Wanted;

                    _Phys_Def = 5;
                    _Elem_Def = 10;

                    break;

                //**********| Benoit |**********//

                //Torse
                case "Tunique ensorcelée":
                    _Name = armor_Wanted;

                    _Phys_Def = 5;
                    _Elem_Def = 10;

                    break;

                //**********| Ailphynna |**********//

                //Tête
                case "Bois de cerf":
                    _Name = armor_Wanted;

                    _Phys_Def = 10;
                    _Elem_Def = 5;

                    break;
               
                default:
                    break;
            }
        }
    }
}