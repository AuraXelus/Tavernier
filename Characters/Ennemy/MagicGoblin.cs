namespace Tavernier
{
    internal class MagicGoblin : Character
    {
        public MagicGoblin()
        {
            _Max_HP = 100;
            _HP = _Max_HP;

            _Max_SP = 60;
            _Phys_Atk = 10;
            _Elem_Atk = 25;

            _Phys_Def = 5;
            _Elem_Def = 40;

            _Accuracy = 70;
            _Critical_Chance = 3;
            _Critical_Dmg = 2;

            _Speed = 70;
        }
    }
}