using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tavernier.Item
{
    internal class Potions : Item
    {
        protected string _Name = "None";

        protected int _Healing = 0;
        protected int _SP_Recovery = 0;
        protected int _Atk_Buff = 0;
        protected int _Def_Buff = 0;

        public Potions()
        {

        }
        public void choose_Potion(string Potion_Wanted)
        {
            switch (Potion_Wanted)
            {
                case "Healing potion":
                    _Name = Potion_Wanted;

                    _Healing = 30;

                    break;

                case "Recovery potion":
                    _Name = Potion_Wanted;

                    _SP_Recovery = 25;

                    break;

                case "Rage potion":
                    _Name = Potion_Wanted;

                    _Atk_Buff = 10;

                    break;

                case "Ironskin potion":
                    _Name = Potion_Wanted;

                    _Def_Buff = 10;

                    break;

                default:
                    break;
            }
        }
    }
}
