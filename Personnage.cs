using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tavernier
{
    internal class Character
    {
        protected int _Max_HP;
        protected int _HP;
        protected int _Phys_Atk;
        protected int _Phys_Def;
        protected int _Accuracy;
        protected int _Critical_Chance;
        protected int _Critical_Puiss;

        protected int _Max_SP;
        protected int _Elem_Atk;
        protected int _Elem_Def;
        protected int _Speed;

        Item Arme1 = new Item();


        public Character() 
        {
        
        }

        public virtual void attack(Character cible)
        {
            cible.receveDammage(_Phys_Atk);
        }

        public virtual void receveDammage(int degats)
        {
            _HP -= (degats - _Phys_Def);
        }

        //Get
        public virtual int getHP()
        {
            return _HP;
        }
    }
}

//Objet (armes) potions vie, mana, 