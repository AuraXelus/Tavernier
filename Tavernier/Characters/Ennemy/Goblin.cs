namespace Tavernier.Characters.Ennemy
{
    internal class Goblin : Player
    {
        public Goblin()
        {
            _Max_HP = 85;
            _HP = _Max_HP;
            _Max_SP = 0;
            _SP = _Max_SP;

            _Phys_Atk = 30;
            _Elem_Atk = 50;

            _Phys_Def = 10;
            _Elem_Def = 5;

            _Accuracy = 85;
            _Critical_Chance = 3;
            _Critical_Puiss = 2;

            _Speed = 80;
        }
    }
}