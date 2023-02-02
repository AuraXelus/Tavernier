﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tavernier
{
    public class Skill
    {
        private string _Name = "None";
        private int _Number_Skill = 0;
        private int _Point_SP = 0;

        private bool _Phys_Atk = false;
        private bool _Elem_Atk = false;
        private float _Modif_dmg = 0;


        public Skill() { }


        public void setSkill(string characterSkill, int numberSkill)
        {
            switch (characterSkill)
            {
                case "Balfis":
                    switch (numberSkill)
                    {
                        case 1: //Maintenant 120%. Ele fera 75% de degats mais stun l'ennemie 1T
                            _Name = "Charge";
                            _Number_Skill = numberSkill;
                            _Point_SP = 20;
                            _Phys_Atk = true;
                            _Elem_Atk = false;

                            _Modif_dmg = 120;
                            break;
                        case 2: //60% degats à tous les ennemies
                            _Name = "Whirlwind";
                            _Number_Skill = numberSkill;
                            _Point_SP = 30;
                            _Phys_Atk = true;
                            _Elem_Atk = false;

                            _Modif_dmg = 60;
                            break;
                        default:
                            break;
                    }
                    break;

                case "Nina":
                    switch (numberSkill)
                    {
                        case 1: //Maintenant 120%. Ele fera 75% de degats mais stun l'ennemie 1T
                            _Name = "Weapon Enchantment";
                            _Number_Skill = numberSkill;
                            _Point_SP = 40;
                            _Phys_Atk = false;
                            _Elem_Atk = true;

                            _Modif_dmg = 150;
                            break;
                        case 2: //60% degats à tous les ennemies
                            _Name = "Piercing sword";
                            _Number_Skill = numberSkill;
                            _Point_SP = 5;
                            _Phys_Atk = true;
                            _Elem_Atk = false;

                            _Modif_dmg = 110;
                            break;
                        default:
                            break;
                    }
                    break;

                case "Elizendre":
                    switch (numberSkill)
                    {
                        case 1: //Maintenant 120%. Ele fera 75% de degats mais stun l'ennemie 1T
                            _Name = "Frost Shard";
                            _Number_Skill = numberSkill;
                            _Point_SP = 10;
                            _Phys_Atk = false;
                            _Elem_Atk = true;

                            _Modif_dmg = 130;
                            break;
                        case 2: //60% degats à tous les ennemies
                            _Name = "Blizzard";
                            _Number_Skill = numberSkill;
                            _Point_SP = 30;
                            _Phys_Atk = false;
                            _Elem_Atk = true;

                            _Modif_dmg = 150;
                            break;
                        default:
                            break;
                    }
                    break;

                case "Laevis":
                    switch (numberSkill)
                    {
                        case 1: //Maintenant 120%. Ele fera 75% de degats mais stun l'ennemie 1T
                            _Name = "Stick hit";
                            _Number_Skill = numberSkill;
                            _Point_SP = 10;
                            _Phys_Atk = true;
                            _Elem_Atk = false;

                            _Modif_dmg = 105;
                            break;
                        case 2: //60% degats à tous les ennemies
                            _Name = "Tree power";
                            _Number_Skill = numberSkill;
                            _Point_SP = 30;
                            _Phys_Atk = false;
                            _Elem_Atk = true;

                            _Modif_dmg = 110;
                            break;
                        default:
                            break;
                    }
                    break;
                default:
                    break;
            }
        }
        public string Name { get => _Name; set => _Name = value; }
        public int Number_Skill { get => _Number_Skill; set => _Number_Skill = value; }
        public int Point_SP { get => _Point_SP; set => _Point_SP = value; }
        public bool Phys_Atk { get => _Phys_Atk; set => _Phys_Atk = value; }
        public bool Elem_Atk { get => _Elem_Atk; set => _Elem_Atk = value; }
        public float Modif_dmg { get => _Modif_dmg; set => _Modif_dmg = value; }
    }
}
