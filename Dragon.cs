namespace Tavernier
{
    internal class Dragon : Character
    {
        public Dragon()
        {
            _Max_HP = 200;
            _HP = _Max_HP;

            _Max_SP = 40;
            _Phys_Atk = 120;
            _Elem_Atk = 80;

            _Phys_Def = 300;
            _Elem_Def = 20;

            _Accuracy = 95;
            _Critical_Chance = 5;
            _Critical_Dmg = 2;

            _Speed = 40;
        }
    }
}