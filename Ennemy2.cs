namespace Tavernier
{
    internal class Ennemy2 : Character
    {
        public Ennemy2()
        {
            _Max_HP = 50;
            _HP = _Max_HP;

            _Max_SP = 60;
            _Phys_Atk = 10;
            _Elem_Atk = 45;

            _Phys_Def = 20;
            _Elem_Def = 55;

            _Accuracy = 70;
            _Critical_Chance = 3;
            _Critical_Dmg = 2;

            _Speed = 70;
        }
    }
}