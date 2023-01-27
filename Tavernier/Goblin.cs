namespace Tavernier
{
    internal class Goblin : Enemy
    {
        public Goblin()
        {
            _Name= "Goblin";
            _Max_HP = 100;
            _HP = _Max_HP;

            _Max_SP = 60;
            _Phys_Atk = 25;
            _Elem_Atk = 10;

            _Phys_Def = 10;
            _Elem_Def = 5;

            _Accuracy = 70;
            _Critical_Chance = 3;
            _Critical_Puiss = 2;

            _Speed = 70;

            _Exp_Give = 50;
        }
    }
}