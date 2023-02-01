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

        private bool _Escape_Succes = false;
        public Fight_State()
        {

        }

        public void runFight(Character player, Character enemy)
        {
            Console.Clear();
            //Init Fight
            if (player.Speed >= enemy.Speed) { _CharacterTurn = 0; }
            else { _CharacterTurn = 1; }

            //Fight
            do
            {
                if (_CharacterTurn % 2 == 0)
                {
                    _Round_Finish = false;
                    do
                    {
                        display(player, enemy);
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
                                    choiceSkill(player, enemy);    //Directement dans choiceSkil
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
                else if (_CharacterTurn % 2 == 1)
                {
                    display(player, enemy);
                    Console.ReadKey(true);
                    Console.WriteLine("L'ennemi vous attaque, avec une attaque physqieu, l'IA n'est pas faites il vous attaque comme ça en boucle le con");
                    enemy.attack(player);
                    Console.ReadKey(true);
                    Console.Clear();
                }
                _CharacterTurn++;
            } while ((player.Alive == true && enemy.Alive == true) && _Escape_Succes != true);

            //End Fight
            if (_Escape_Succes == true) { Console.WriteLine("Tu réussie à fuire (enculé)"); }
            else { Console.WriteLine("Congratulation. Your become defeated your first ennemy."); }
        }

        public void display(Character player, Character enemy)
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
            else if (_CharacterTurn % 2 == 1)
            {
                Console.WriteLine("                                                |Ennmy turn");
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
            Console.Write("                                                |You attack");
            Console.ReadKey(true);
            Console.Clear();
            //Du coup ça le fait 

            player.attack(enemy);
        }

        public void choiceSkill(Character player, Character enemy)
        {
            bool choiceSkillOk = false;
            bool skill1 = true;
            bool skill2 = false;
            bool skill3 = false;
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
                    Console.WriteLine("                                             |*Skill n°1        |Skill n°2 ");
                    Console.WriteLine("                                             |Skill n°3         |Back ");
                }
                else if (skill2 == true)
                {
                    Console.WriteLine("                                             |Skill n°1         |*Skill n°2 ");
                    Console.WriteLine("                                             |Skill n°3         |Back ");
                }
                else if (skill3 == true)
                {
                    Console.WriteLine("                                             |Skill n°1         |Skill n°2 ");
                    Console.WriteLine("                                             |*Skill n°3        |Back ");
                }
                else if (back == true)
                {
                    Console.WriteLine("                                             |Skill n°1         |Skill n°2 ");
                    Console.WriteLine("                                             |Skill n°3         |*Back ");
                }

                //Choose and action
                ConsoleKey key = Console.ReadKey(true).Key;
                switch (key)
                {
                    case ConsoleKey.Enter:
                        if (skill1 == true)
                        {
                            if (player.First_Skill.Name != "None") { choiceSkillOk = true; player.useSkill(enemy, 1); _Round_Finish = true; }
                            else if (player.First_Skill.Point_SP > player.SP) { Console.WriteLine("                                                |You don't have enough SP|"); Console.ReadKey(true); Console.Clear(); }

                            else { Console.WriteLine("                                                |You don't learn this skill|"); Console.ReadKey(true); Console.Clear(); }
                        }
                        else if (skill2 == true)
                        {
                            if (player.Second_Skill.Name != "None") { choiceSkillOk = true; player.useSkill(enemy, 2); _Round_Finish = true; }
                            else if (player.Second_Skill.Point_SP > player.SP) { Console.WriteLine("                                                |You don't have enough SP|"); Console.ReadKey(true); Console.Clear(); }
                            else { Console.WriteLine("                                                |You don't learn this skill|"); Console.ReadKey(true); Console.Clear(); }
                        }
                        else if (skill3 == true)
                        {
                            if (player.Third_Skill.Name != "None") { choiceSkillOk = true; player.useSkill(enemy, 3); _Round_Finish = true; }
                            else if (player.Third_Skill.Point_SP > player.SP) { Console.WriteLine("                                                |You don't have enough SP|"); Console.ReadKey(true); Console.Clear(); }

                            else { Console.WriteLine("                                                |You don't learn this skill|"); Console.ReadKey(true); Console.Clear(); }
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
                        if (back == true) { back = false; skill3 = true; }
                        break;
                    case ConsoleKey.UpArrow:
                        if (skill3 == true) { skill3 = false; skill1 = true; }
                        if (back == true) { back = false; skill2 = true; }
                        break;
                    case ConsoleKey.RightArrow:
                        if (skill1 == true) { skill1 = false; skill2 = true; }
                        if (skill3 == true) { skill3 = false; back = true; }
                        break;
                    case ConsoleKey.DownArrow:
                        if (skill1 == true) { skill1 = false; skill3 = true; }
                        if (skill2 == true) { skill2 = false; back = true; }
                        break;
                    default:
                        break;
                }
                } while (choiceSkillOk != true) ;
            Console.Clear();
            Console.WriteLine("                                                |Vous utiliser votre compétence|");
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
                        }
                        else if (useSP == true)
                        {
                            Console.WriteLine("                                                |You use SP potion|");
                        }
                        else if (changeCharacter == true)
                        {
                            Console.WriteLine("                                                |CHANGER DE CHARACTER|");
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
            Console.Clear();
            Console.WriteLine("                         |Vous utiliser votre compétence|");
            Console.ReadKey(true);
            Console.Clear();
        }

        public void choiceEscape(Character player, Character ennemy)
        {
            Console.Clear();
            Console.WriteLine("                                             ANIMATION DE FOU");
            Console.WriteLine("                                             Tu fuis le combat");
            Console.WriteLine("                                             VICTIME");
            Console.WriteLine("                                             VICTIME");
            Console.ReadKey(true);
            Console.Clear();
            //Du coup ça le fait 
            _Escape_Succes = true;
        }
    }
}

//Bag ou //Oui alors tout à fait mon cher Henry je suis totalement en train de faire semblant de travailler 