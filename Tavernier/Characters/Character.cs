﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tavernier.Characters.Ennemy;

namespace Tavernier
{
    public class Character
    {
        protected string _Name = "None";

        protected int _Max_HP;
        protected int _HP;
        protected int _Max_SP;
        protected int _SP;
        protected string _Elem_Type = "None";

        protected int _Exp;
        protected int _Lvl;

        protected int _Phys_Atk;
        protected int _Elem_Atk;
        protected int _Phys_Def;
        protected int _Elem_Def;

        protected int _Accuracy;
        protected int _Critical_Chance;
        protected int _Critical_Puiss;
        protected int _Speed;

        protected string _Name_First_Weapon = "None";
        protected Weapon _First_Weapon = new Weapon();

        protected Skill _First_Skill = new Skill();
        protected Skill _Second_Skill = new Skill();
        protected Skill _Third_Skill = new Skill();

        protected bool _Alive = true;

        protected bool _Weakness_Slash = false;
        protected bool _Weakness_Thrust = false;
        protected bool _Weakness_Strike = false;

        protected bool _Weakness_Fire = false;
        protected bool _Weakness_Ice = false;
        protected bool _Weakness_Nature = false;

        protected string _Sprite = "None";
        public Character() 
        {
        
        }

        public virtual void attack(Character target)
        {
            double damage = (_Phys_Atk + _First_Weapon.Phy_Atk) - target._Phys_Def;
            if (_First_Weapon.Slash == true && target.Weakness_Slash == true)
            {
                damage *= 1.2;
            }
            else if (_First_Weapon.Thrust == true && target.Weakness_Thrust == true)
            {
                damage *= 1.2;
            }
            else if (_First_Weapon.Strike == true && target.Weakness_Strike == true)
            {
                damage *= 1.2;
            }
            int finalDamage = (int)damage;
            target.receveDammage(finalDamage);
        }

        public virtual void useSkill(Character target, int numberSkill)
        {
            double damage = 0;
            switch (numberSkill)
            {
                case 1:
                    if(_First_Skill.Phys_Atk == true) 
                    {
                        damage = (_Phys_Atk + _First_Weapon.Phy_Atk);
                        damage *= (_First_Skill.Modif_dmg / 100);
                        _SP -= _First_Skill.Point_SP;
                        if (_First_Weapon.Slash == true && target.Weakness_Slash == true) { damage *= 1.2; }
                        else if (_First_Weapon.Thrust == true && target.Weakness_Thrust == true)
                        {
                            damage *= 1.2;
                        }
                        else if (_First_Weapon.Strike == true && target.Weakness_Strike == true)
                        {
                            damage *= 1.2;
                        }
                        damage -= target.Phys_Def;
                    }
                    else if (_First_Skill.Elem_Atk == true)
                    {
                        damage = (_Elem_Atk + _First_Weapon.Elem_Atk);
                        damage *= (_First_Skill.Modif_dmg / 100);
                        _SP -= _First_Skill.Point_SP;
                        if(_Elem_Type == "Fire" && target.Weakness_Fire == true) { damage *= 1.3; }
                        if (_Elem_Type == "Ice" && target.Weakness_Ice == true) { damage *= 1.3; }
                        if (_Elem_Type == "Natue" && target.Weakness_Nature == true) { damage *= 1.3; }
                        damage -= target.Elem_Def;
                    }
                    break;
                case 2:
                    if (_Second_Skill.Phys_Atk == true)
                    {
                        damage = (_Phys_Atk + _First_Weapon.Phy_Atk);
                        damage *= (_Second_Skill.Modif_dmg / 100);
                        _SP -= _Second_Skill.Point_SP;
                        if ((_First_Weapon.Slash == true && target.Weakness_Slash == true))
                        {
                            damage *= 1.2;
                        }
                        else if (_First_Weapon.Thrust == true && target.Weakness_Thrust == true)
                        {
                            damage *= 1.2;
                        }
                        else if (_First_Weapon.Strike == true && target.Weakness_Strike == true)
                        {
                            damage *= 1.2;
                        }
                        damage -= target.Phys_Def;
                    }
                    else if (_Second_Skill.Elem_Atk == true)
                    {
                        damage = (_Elem_Atk + _First_Weapon.Elem_Atk);
                        damage *= (_Second_Skill.Modif_dmg / 100);
                        _SP -= _Second_Skill.Point_SP;
                        if (_Elem_Type == "Fire" && target.Weakness_Fire == true) { damage *= 1.3; }
                        else if (_Elem_Type == "Ice" && target.Weakness_Ice == true) { damage *= 1.3; }
                        else if (_Elem_Type == "Natue" && target.Weakness_Nature == true) { damage *= 1.3; }
                        damage -= target.Elem_Def;
                    }
                    break;

                default:
                    break;
            }
            int finalDamage = (int)damage; //Round celling floor
            target.receveDammage(finalDamage);
        }

        public virtual void receveDammage(int damage)
        {
            if(damage <= 0) { _HP--; } else { _HP -= damage; }

            if(_HP <= 0) { _Alive = false; }
        }

        public virtual void heal(int heal)
        {
            _HP += heal;
            if(_HP > _Max_HP) { _HP = _Max_HP; }
        }

        public virtual void healMax()
        {
            _HP = _Max_HP;
        }

        //Get
        public string Name { get => _Name; set => _Name = value; }
        public int Max_HP { get => _Max_HP; set => _Max_HP = value; }
        public int HP { get => _HP; set => _HP = value; }
        public int Max_SP { get => _Max_SP; set => _Max_SP = value; }
        public int SP { get => _SP; set => _SP = value; }


        protected int Exp { get => _Exp; set => _Exp = value; }
        protected int Lvl { get => _Lvl; set => _Lvl = value; }

        public int Phys_Atk { get => _Phys_Atk; set => _Phys_Atk = value; }
        public int Elem_Atk { get => _Elem_Atk; set => _Elem_Atk = value; }
        public int Phys_Def { get => _Phys_Def; set => _Phys_Def = value; }
        public int Elem_Def { get => _Elem_Def; set => _Elem_Def = value; }
        public int Speed { get => _Speed; set => _Speed = value; }
        public Weapon First_Weapon { get => _First_Weapon; set => _First_Weapon = value; }
        public bool Alive { get => _Alive; set => _Alive = value; }

        public Skill First_Skill { get => _First_Skill; set => _First_Skill = value; }
        public Skill Second_Skill { get => _Second_Skill; set => _Second_Skill = value; }
        public Skill Third_Skill { get => _Third_Skill;set => _Third_Skill = value; }

        public bool Weakness_Slash { get => _Weakness_Slash; set => _Weakness_Slash = value; }
        public bool Weakness_Thrust { get => _Weakness_Thrust; set => _Weakness_Thrust = value; }
        public bool Weakness_Strike { get => _Weakness_Strike; set => _Weakness_Strike = value; }
        public bool Weakness_Fire { get => _Weakness_Fire; set => _Weakness_Fire = value; }
        public bool Weakness_Ice { get => _Weakness_Ice; set => _Weakness_Ice = value; }
        public bool Weakness_Nature { get => _Weakness_Nature; set => _Weakness_Nature = value; }

        public string Sprite { get => _Sprite; set => _Sprite = value;}
    }
}