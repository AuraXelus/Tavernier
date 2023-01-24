using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tavernier
{
    internal class Character
    {
        protected string _Name = "None";

        protected int _Max_HP;
        protected int _HP;
        protected int _Max_SP;

        protected int _Phys_Atk;
        protected int _Phys_Def;
        protected int _Accuracy;
        protected int _Critical_Chance;
        protected int _Critical_Puiss;

        protected int _Elem_Atk;
        protected int _Elem_Def;
        protected int _Speed;

        protected string _Name_First_Weapon = "None";
        protected Weapon _First_Weapon = new Weapon();

        protected bool _Alive = true;

        public Character() 
        {
        
        }

        public virtual void attack(Character cible)
        {
            int damage = (_Phys_Atk + _First_Weapon.Atk_Phy) - cible._Phys_Def;
            cible.receveDammage(damage);
        }

        public virtual void receveDammage(int damage)
        {
            if(damage <= 0) { _HP--; } else { _HP -= damage; }

            if(_HP <= 0) { _Alive = false; }
        }

        //Get
        public string Name { get => _Name; set => _Name = value; }
        public int Max_HP { get => _Max_HP; set => _Max_HP = value; }
        public int HP { get => _HP; set => _HP = value; }
        public int Phys_Atk { get => _Phys_Atk; set => _Phys_Atk = value; }
        public int Speed { get => _Speed; set => _Speed = value; }
        public Weapon First_Weapon { get => _First_Weapon; set => _First_Weapon = value; }

        public bool Alive { get => _Alive; set => _Alive = value; }
    }
}

//Objet (armes) potions vie, mana, 