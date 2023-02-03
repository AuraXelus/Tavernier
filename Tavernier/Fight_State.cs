using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tavernier
{
    public class Fight_State
    {
        private bool _Attack = true;
        private bool _Skill = false;
        private bool _Bag = false;
        private bool _Escape = false;
        private bool _Round_Finish = false;
        private int _CharacterTurn;    //Si c'est paire c'est à nous de jouer

        private int stockRandom = 0;
        private Random random = new Random();

        private bool _Escape_Success = false;
        private bool _Change_Character = false;

        public Fight_State()
        {

        }

        public void runFight(Character player, Character enemy)
        {
            Console.Clear();
            //Init Fight
            _Escape_Success = false;
            _Change_Character = false;
            if (player.Speed >= enemy.Speed) { _CharacterTurn = 0; }
            else { _CharacterTurn = 1; }

            //Fight
            do
            {
                if (_CharacterTurn % 2 == 0)    //Player turn
                {
                    _Round_Finish = false;
                    do
                    {
                        displayChoice(player, enemy);
                        ConsoleKey key = Console.ReadKey(true).Key;

                        switch (key)
                        {
                            case ConsoleKey.Enter:
                                if (_Attack == true)
                                {
                                    choiceAttack(player, enemy);
                                    _Round_Finish = true;
                                }
                                else if (_Skill == true)
                                {
                                    choiceSkill(player, enemy);
                                }
                                else if (_Bag == true)
                                {
                                    choiceBag(player, enemy);
                                }
                                else if (_Escape == true)
                                {
                                    choiceEscape(player, enemy);
                                    _Round_Finish = true;
                                }
                                break;

                            case ConsoleKey.LeftArrow:
                                if (_Skill == true) { _Skill = false; _Attack = true; }
                                if (_Escape == true) { _Escape = false; _Bag = true; }
                                break;
                            case ConsoleKey.UpArrow:
                                if (_Bag == true) { _Bag = false; _Attack = true; }
                                if (_Escape == true) { _Escape = false; _Skill = true; }
                                break;
                            case ConsoleKey.RightArrow:
                                if (_Attack == true) { _Attack = false; _Skill = true; }
                                if (_Bag == true) { _Bag = false; _Escape = true; }
                                break;
                            case ConsoleKey.DownArrow:
                                if (_Attack == true) { _Attack = false; _Bag = true; }
                                if (_Skill == true) { _Skill = false; _Escape = true; }
                                break;
                            default:
                                break;
                        }
                        Console.SetCursorPosition(0, 0);
                    } while (_Round_Finish != true);
                }
                else if (_CharacterTurn % 2 == 1)   //Enemy turn
                {
                    Console.WriteLine("         |{0}|    -    |HP : {1}|", enemy.Name, enemy.HP);
                    Console.WriteLine(enemy.Sprite);
                    Console.WriteLine(player.Sprite);
                    Console.WriteLine("                                                                                       |{0}|  ", player.Name);
                    Console.WriteLine("                                                                                       |HP : {0}/{1}| ", player.HP, player.Max_HP);
                    Console.WriteLine("                                                                                       |SP : {0}/{1}| ", player.SP, player.Max_SP);
                    stockRandom = random.Next(1, 101);
                    if (stockRandom <= enemy.Critical_Chance)
                    {
                        if(enemy.choiceIA(player) == "Phys") 
                        { 
                            enemy.criticalAttack(player);
                            Console.WriteLine("                                               |Enemy use  a critical attack|");
                            Console.WriteLine("                                                  |You receve {0} damages|", enemy.damageAttack(player) * enemy.Critical_Puiss);
                        }
                        else 
                        { 
                            enemy.criticalAttackElem(player);
                            Console.WriteLine("                                              |Enemy use  a critical attack elem|");
                            Console.WriteLine("                                                  |You receve {0} damages|", enemy.damageAttackElem(player) * enemy.Critical_Puiss);
                        }

                    }
                    else
                    {
                        if(enemy.choiceIA(player) == "Phys")
                        {
                        enemy.attack(player);
                        Console.WriteLine("                                                |Enemy use a normal attack|");
                        Console.WriteLine("                                                 |You receve {0} damages|", enemy.damageAttack(player));
                        }
                        else
                        {
                            enemy.attackElem(player);
                            Console.WriteLine("                                              |Enemy use a normal attack elem|");
                            Console.WriteLine("                                                 |You receve {0} damages|", enemy.damageAttackElem(player));
                        }
                    }
                    Console.ReadKey(true);
                    Console.Clear();
                }

                if(player.Alive == false || _Change_Character == true)
                {
                    return;
                }
                _CharacterTurn++;
            } while (enemy.Alive == true && _Escape_Success != true);

            //End Fight
            if(player.Alive == true)  
            {
                Console.WriteLine("         |{0}|    -    |HP : {1}|", enemy.Name, enemy.HP);
                Console.WriteLine(enemy.Sprite);
                Console.WriteLine(player.Sprite);
                Console.WriteLine("                                                                                       |{0}|  ", player.Name);
                Console.WriteLine("                                                                                       |HP : {0}/{1}| ", player.HP, player.Max_HP);
                Console.WriteLine("                                                                                       |SP : {0}/{1}| ", player.SP, player.Max_SP);
                Console.WriteLine("                                                |Congratulation. Your defeated your ennemy|");
                Console.ReadKey(true);
                Console.Clear();
            }
        }

        public void displayChoice(Character player, Character enemy)
        {
            Console.WriteLine("         |{0}|    -    |HP : {1}|", enemy.Name, enemy.HP);
            Console.WriteLine(enemy.Sprite);
            Console.WriteLine(player.Sprite);
            Console.WriteLine("                                                                                       |{0}|  ", player.Name);
            Console.WriteLine("                                                                                       |HP : {0}/{1}| ", player.HP, player.Max_HP);
            Console.WriteLine("                                                                                       |SP : {0}/{1}| ", player.SP, player.Max_SP);
            if (_CharacterTurn%2 == 0)
            {
            if (_Attack == true)
            {
                Console.WriteLine("                                             |*Attack          |Skill ");
                Console.WriteLine("                                             |Bag              |Escape ");
            }
            else if (_Skill == true)
            {
                Console.WriteLine("                                             |Attack           |*Skill ");
                Console.WriteLine("                                             |Bag              |Escape ");
            }
            else if (_Bag == true)
            {
                Console.WriteLine("                                             |Attack           |Skill ");
                Console.WriteLine("                                             |*Bag             |Escape ");
            }
            else if (_Escape == true)
            {
                Console.WriteLine("                                             |Attack           |Skill ");
                Console.WriteLine("                                             |Bag              |*Escape ");
            }
            }
        }

        public void choiceAttack(Character player, Character enemy)
        {
            Console.Clear();
            Console.SetCursorPosition(0, 0);
            Console.WriteLine("         |{0}|    -    |HP : {1}|", enemy.Name, enemy.HP);
            Console.WriteLine(enemy.Sprite);
            Console.WriteLine(player.Sprite);
            Console.WriteLine("                                                                                       |{0}|  ", player.Name);
            Console.WriteLine("                                                                                       |HP : {0}/{1}| ", player.HP, player.Max_HP);
            Console.WriteLine("                                                                                       |SP : {0}/{1}| ", player.SP, player.Max_SP);
            stockRandom = random.Next(1, 101);
            if(stockRandom <= player.Critical_Chance) 
            {
                player.criticalAttack(enemy);
                Console.WriteLine("                                                |You do a critical attack|");
                Console.WriteLine("                                              |The enemy receve {0} damages|", player.damageAttack(enemy)*player.Critical_Puiss);
            }
            else
            {
                player.attack(enemy);
                Console.WriteLine("                                                |You attack your ennemy|");
                Console.WriteLine("                                              |The enemy receve {0} damages|", player.damageAttack(enemy));
            }
            Console.ReadKey(true);
            Console.Clear();
            //Du coup ça le fait 


        }

        public void choiceSkill(Character player, Character enemy)
        {
            bool choiceSkillOk = false;
            bool skill1 = true;
            bool skill2 = false;
            bool back = false;
            Console.Clear();
            do
            {
                //Display
                Console.SetCursorPosition(0, 0);
                Console.WriteLine("         |{0}|    -    |HP : {1}|", enemy.Name, enemy.HP);
                Console.WriteLine(enemy.Sprite);
                Console.WriteLine(player.Sprite);
                Console.WriteLine("                                                                                       |{0}|  ", player.Name);
                Console.WriteLine("                                                                                       |HP : {0}/{1}| ", player.HP, player.Max_HP);
                Console.WriteLine("                                                                                       |SP : {0}/{1}| ", player.SP, player.Max_SP);
                if (skill1 == true)
                {
                    Console.WriteLine("                                        |*{0}        |{1} ", player.First_Skill.Name, player.Second_Skill.Name);
                    Console.WriteLine("                                                 |Back ");
                }
                else if (skill2 == true)
                {
                    Console.WriteLine("                                        |{0}        |*{1} ", player.First_Skill.Name, player.Second_Skill.Name);
                    Console.WriteLine("                                                 |Back ");
                }
                else if (back == true)
                {
                    Console.WriteLine("                                        |{0}        |{1} ", player.First_Skill.Name, player.Second_Skill.Name);
                    Console.WriteLine("                                                 |*Back ");
                }

                //Choose and action
                ConsoleKey key = Console.ReadKey(true).Key;
                switch (key)
                {
                    case ConsoleKey.Enter:
                        Console.Clear();
                        if (skill1 == true)
                        {
                            if(player.SP < player.First_Skill.Point_SP) { Console.WriteLine("                                                |You don't have enough SP|"); }
                            else
                            {
                                Console.WriteLine("         |{0}|    -    |HP : {1}|", enemy.Name, enemy.HP);
                                Console.WriteLine(enemy.Sprite);
                                Console.WriteLine(player.Sprite);
                                Console.WriteLine("                                                                                       |{0}|  ", player.Name);
                                Console.WriteLine("                                                                                       |HP : {0}/{1}| ", player.HP, player.Max_HP);
                                Console.WriteLine("                                                                                       |SP : {0}/{1}| ", player.SP, player.Max_SP);
                                stockRandom = random.Next(1, 101);
                                if (stockRandom <= player.Critical_Chance)
                                {
                                    player.criticalSkill(enemy, 1);
                                    Console.WriteLine("                                        |You use {0} and do critical damage|", player.First_Skill.Name);
                                    Console.WriteLine("                                              |The enemy receve {0} damages|", Math.Floor(player.damageSkill(enemy, 1) * player.Critical_Puiss));
                                }
                                else
                                {
                                    player.skill(enemy, 1);
                                    Console.WriteLine("                                              |You use {0}|", player.First_Skill.Name);
                                    Console.WriteLine("                                              |The enemy receve {0} damages|", Math.Floor(player.damageSkill(enemy, 1)));
                                }
                                choiceSkillOk = true;
                                _Round_Finish = true;
                            }
                        }
                        else if (skill2 == true)
                        {
                            if (player.SP < player.Second_Skill.Point_SP) { Console.WriteLine("                                                |You don't have enough SP|"); }
                            else
                            {
                                Console.WriteLine("         |{0}|    -    |HP : {1}|", enemy.Name, enemy.HP);
                                Console.WriteLine(enemy.Sprite);
                                Console.WriteLine(player.Sprite);
                                Console.WriteLine("                                                                                       |{0}|  ", player.Name);
                                Console.WriteLine("                                                                                       |HP : {0}/{1}| ", player.HP, player.Max_HP);
                                Console.WriteLine("                                                                                       |SP : {0}/{1}| ", player.SP, player.Max_SP);
                                stockRandom = random.Next(1, 101);
                                if (stockRandom <= player.Critical_Chance)
                                {
                                    player.criticalSkill(enemy, 2);
                                    Console.WriteLine("                                        |You use {0} and do critical damage|", player.Second_Skill.Name);
                                    Console.WriteLine("                                              |The enemy receve {0} damages|", Math.Floor(player.damageSkill(enemy, 2) * player.Critical_Puiss));
                                }
                                else
                                {
                                    player.skill(enemy, 2);
                                    Console.WriteLine("                                              |You use {0}|", player.Second_Skill.Name);
                                    Console.WriteLine("                                              |The enemy receve {0} damages|", Math.Floor(player.damageSkill(enemy, 2)));
                                }
                                choiceSkillOk = true;
                                _Round_Finish = true;
                            }
                        }
                        else if (back == true)
                        {
                            choiceSkillOk = true;
                            Console.Clear();
                            return;
                        }
                        break;

                    case ConsoleKey.LeftArrow:
                        if (skill2 == true) { skill2 = false; skill1 = true; }
                        break;
                    case ConsoleKey.UpArrow:
                        if (back == true) { back = false; skill1 = true; }
                        break;
                    case ConsoleKey.RightArrow:
                        if (skill1 == true) { skill1 = false; skill2 = true; }
                        break;
                    case ConsoleKey.DownArrow:
                        if (skill1 == true) { skill1 = false; back = true; }
                        if (skill2 == true) { skill2 = false; back = true; }
                        break;
                    default:
                        break;
                }
                } while (choiceSkillOk != true) ;
            Console.ReadKey(true);
            Console.Clear();

        }

        public void choiceBag(Character player, Character enemy)
        {
            bool choiceSkillOk = false;
            bool useHeal = true;
            bool useSP = false;
            bool changeCharacter = false;
            bool back = false;
            Console.Clear();
            do
            {
                //Display
                Console.SetCursorPosition(0, 0);
                Console.WriteLine("         |{0}|    -    |HP : {1}|", enemy.Name, enemy.HP);
                Console.WriteLine(enemy.Sprite);
                Console.WriteLine(player.Sprite);
                Console.WriteLine("                                                                                       |{0}|  ", player.Name);
                Console.WriteLine("                                                                                       |HP : {0}/{1}| ", player.HP, player.Max_HP);
                Console.WriteLine("                                                                                       |SP : {0}/{1}| ", player.SP, player.Max_SP);
                if (useHeal == true)
                {
                    Console.WriteLine("                                             |*Use heal potion  |Use SP potion ");
                    Console.WriteLine("                                             |Change character  |Back ");
                }
                else if (useSP == true)
                {
                    Console.WriteLine("                                             |Use heal potion   |*Use SP potion ");
                    Console.WriteLine("                                             |Change character  |Back ");
                }
                else if (changeCharacter == true)
                {
                    Console.WriteLine("                                             |Use heal potion   |Use SP potion ");
                    Console.WriteLine("                                             |*Change character |Back ");
                }
                else if (back == true)
                {
                    Console.WriteLine("                                             |Use heal potion   |Use SP potion ");
                    Console.WriteLine("                                             |Change character  |*Back ");
                }

                //Choose and action
                ConsoleKey key = Console.ReadKey(true).Key;
                switch (key)
                {
                    case ConsoleKey.Enter:
                        if (useHeal == true)
                        {
                            Console.WriteLine("                                                |You use heal potion|");
                            player.healMax();
                            choiceSkillOk = true;
                        }
                        else if (useSP == true)
                        {
                            Console.WriteLine("                                                |You use SP potion|");
                            player.SPMax();
                            choiceSkillOk = true;
                        }
                        else if (changeCharacter == true)
                        {
                            _Change_Character = true;
                            choiceSkillOk = true;
                            Console.Clear();
                            return;
                        }
                        else if (back == true)
                        {
                            choiceSkillOk = true;
                            Console.Clear();
                            return;
                        }
                        break;
                    case ConsoleKey.LeftArrow:
                        if (useSP == true) { useSP = false; useHeal = true; }
                        if (back == true) { back = false; changeCharacter = true; }
                        break;
                    case ConsoleKey.UpArrow:
                        if (changeCharacter == true) { changeCharacter = false; useHeal = true; }
                        if (back == true) { back = false; useSP = true; }
                        break;
                    case ConsoleKey.RightArrow:
                        if (useHeal == true) { useHeal = false; useSP = true; }
                        if (changeCharacter == true) { changeCharacter = false; back = true; }
                        break;
                    case ConsoleKey.DownArrow:
                        if (useHeal == true) { useHeal = false; changeCharacter = true; }
                        if (useSP == true) { useSP = false; back = true; }
                        break;
                    default:
                        break;
                }
            } while (choiceSkillOk != true);
            _Round_Finish = true;
            Console.Clear();
            Console.ReadKey(true);
        }

        public void choiceEscape(Character player, Character enemy)
        {
            stockRandom = random.Next(100);
            Console.Clear();
            Console.WriteLine("         |{0}|    -    |HP : {1}|", enemy.Name, enemy.HP);
            Console.WriteLine(enemy.Sprite);
            Console.WriteLine(player.Sprite);
            Console.WriteLine("                                                                                       |{0}|  ", player.Name);
            Console.WriteLine("                                                                                       |HP : {0}/{1}| ", player.HP, player.Max_HP);
            Console.WriteLine("                                                                                       |SP : {0}/{1}| ", player.SP, player.Max_SP);
            if(stockRandom <= player.Speed)
            {
                Console.WriteLine("                                                |Your run away from the fight|");
                _Escape_Success = true;
            }
            else 
            {
                Console.WriteLine("                                                    |Your miss your escape|");
            }
            Console.ReadKey(true);
            Console.Clear();
        }

        //Get
        public bool Escape_Success { get => _Escape_Success; set => _Escape_Success = value;}
    }
}