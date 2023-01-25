namespace Tavernier
{
    internal class WarriorGoblin : Character
    {
        public WarriorGoblin()
        {
            _Max_HP = 100;
            _HP = _Max_HP;
            _Max_SP = 60;
            _SP = _Max_SP;

            _Phys_Atk = 40;
            _Elem_Atk = 10;

            _Phys_Def = 15;
            _Elem_Def = 5;

            _Accuracy = 70;
            _Critical_Chance = 3;
            _Critical_Dmg = 2;

            _Speed = 70;
        }
    }
}