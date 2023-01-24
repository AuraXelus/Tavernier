namespace Tavernier
{
    internal class Goblin : Character
    {
        public Goblin()
        {
            _Name= "Goblin";

            _Max_HP = 50;
            _HP = _Max_HP;
            _Phys_Atk = 40;
            _Phys_Def = 30;
            _Accuracy = 70;
            _Critical_Chance = 10;
            _Critical_Puiss = 2;

            _Max_SP = 40;
            _Elem_Atk = 50;
            _Elem_Def = 55;
            _Speed = 70;
        }
    }
}