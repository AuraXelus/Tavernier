﻿using System;
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

                //1ère arme de Nina
                case "épée":
                    _Name = weapon_Wanted;
                    _Damage = 20;
                    _Critical_Chance = 35;
                    _Slash_Dmg = 30;
                    break;

                //2nd arme de Nina
                case "Lance":
                    _Name = weapon_Wanted;
                    _Damage = 30;
                    _Critical_Chance = 35;
                    _Thrust_Dmg = 50;
                    break;

                default:
                    break;
            }
        }

        //Get
        public int Atk_Phy { get => _Damage; set => _Damage = value; }
    }
}