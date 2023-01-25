namespace Tavernier
{
    internal class GoblinM : Character
    {
        public GoblinM()
        {
            _Max_HP = 80;
            _HP = _Max_HP;

            _Max_SP = 60;
            _Phys_Atk = 10;
            _Elem_Atk = 25;

            _Phys_Def = 10;
            _Elem_Def = 40;

            _Accuracy = 70;
            _Critical_Chance = 3;
            _Critical_Dmg = 2;

            _Speed = 70;
        }
    }
}