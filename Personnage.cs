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

        public Character() 
        {
        
        }

        public virtual void receveDammage(int degat)
        {
            _HP -= degat;
        }

        //Get
        public virtual int getHP()
        {
            return _HP;
        }
    }
}
