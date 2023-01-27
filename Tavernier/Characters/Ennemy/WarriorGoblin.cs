namespace Tavernier
{
    public class WarriorGoblin : Enemy
    {
        public WarriorGoblin()
        {
            _Name= "Warrior Goblin";
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
            _Critical_Puiss = 2;

            _Speed = 70;

            _Slash = true;
            _Thrust = false;
            _Strike = false;

            _Exp_Give = 50;
        }
    }
}