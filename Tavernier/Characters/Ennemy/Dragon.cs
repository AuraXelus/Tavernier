namespace Tavernier.Characters.Ennemy
{
    internal class Dragon : Player
    {
        public Dragon()
        {
            _Max_HP = 800;
            _HP = _Max_HP;
            _Max_SP = 0;
            _SP = _Max_SP;

            _Phys_Atk = 65;
            _Elem_Atk = 40;

            _Phys_Def = 30;
            _Elem_Def = 40;

            _Accuracy = 85;
            _Critical_Chance = 5;
            _Critical_Puiss = 2;

            _Speed = 55;
        }
    }
}