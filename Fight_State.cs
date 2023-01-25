using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tavernier
{
    internal class Fight_State
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

        public void run(Character player, Character ennemy)
        {
            //Init Fight
            if (player.Speed >= ennemy.Speed) { _CharacterTurn = 0; }
            else { _CharacterTurn = 1; }

            //Fight
            do
            {
                if (_CharacterTurn % 2 == 0)
                {
                    _Round_Finish = false;
                    do
                    {
                        display(player, ennemy);
                        ConsoleKey key = Console.ReadKey(true).Key;

                        switch (key)
                        {
                            case ConsoleKey.Enter:
                                if (_Attack == true)
                                {
                                    choiceAttack(player, ennemy);
                                }
                                else if (_Skill == true)
                                {
                                    choiceSkill(player, ennemy);
                                }
                                else if (_Bag == true)
                                {
                                    choiceBag(player);
                                }
                                else if (_Escape == true)
                                {
                                    choiceEscape(player, ennemy);
                                }
                                _Round_Finish = true;
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
                    display(player, ennemy);
                    Console.ReadKey(true);
                    Console.WriteLine("L'ennemi vous attaque, avec une attaque physqieu, l'IA n'est pas faites il vous attaque comme ça en boucle le con");
                    ennemy.attack(player);
                    Console.ReadKey(true);
                    Console.Clear();
                }
                _CharacterTurn++;
            } while ((player.Alive == true && ennemy.Alive == true) && _Escape_Succes != true);

            //End Fight
            if (_Escape_Succes == true) { Console.WriteLine("Tu réussie à fuire (enculé)"); }
            else { Console.WriteLine("Congratulation. Your become defeated your first ennemy."); }
        }

        public void display(Character player, Character ennemy)
        {
            Console.WriteLine("         |{0}|    -    |HP : {1}|", ennemy.Name, ennemy.HP);
            Console.WriteLine("        _   ,_,   _\r\n       / `'=) (='` \\\r\n      /.-.-.\\ /.-.-.\\ \r\n      `      \"      `");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("");
            }
            Console.WriteLine("                                                                                                          /\\_[]_/\\\r\n                                                                                                         |] _||_ [|\r\n                                                                                                  ___     \\/ || \\/\r\n                                                                                                 /___\\       ||\r\n                                                                                                (|0 0|)      ||\r\n                                                                                              __/{\\U/}\\_ ___/vvv\r\n                                                                                             / \\  {~}   / _|_P|\r\n                                                                                             | /\\  ~   /_/   []\r\n                                                                                             |_| (____)        \r\n                                                                                             \\_]/______\\               \r\n                                                                                                _\\_||_/_           \r\n                                                                                               (_,_||_,_)");
            Console.WriteLine("");
            Console.WriteLine("                                                                                       |{0}|    -    |HP : {1}/{2}|", player.Name, player.HP, player.Max_HP);
            if (_CharacterTurn%2 == 0)
            {
            if (_Attack == true)
            {
                Console.WriteLine("");
                Console.WriteLine("                                             |*Attack          |Skill ");
                Console.WriteLine("                                             |Bag              |Escape ");
            }
            else if (_Skill == true)
            {
                Console.WriteLine("");
                Console.WriteLine("                                             |Attack           |*Skill ");
                Console.WriteLine("                                             |Bag              |Escape ");
            }
            else if (_Bag == true)
            {
                Console.WriteLine("");
                Console.WriteLine("                                             |Attack           |Skill ");
                Console.WriteLine("                                             |*Bag             |Escape ");
            }
            else if (_Escape == true)
            {
                Console.WriteLine("");
                Console.WriteLine("                                             |Attack           |Skill ");
                Console.WriteLine("                                             |Bag              |*Escape ");
            }
            }
            else if (_CharacterTurn % 2 == 1)
            {
                Console.WriteLine("");
                Console.WriteLine("                                             |Ennmy turn");
            }
        }

        public void choiceAttack(Character player, Character ennemy)
        {
            Console.Clear();
            Console.WriteLine("                                             ANIMATION DE FOU");
            Console.WriteLine("                                             MESSAGE DE CE QUE CA FAIS");
            Console.ReadKey(true);
            Console.Clear();
            //Du coup ça le fait 

            player.attack(ennemy);
        }

        public void choiceSkill(Character player, Character ennemy)
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
                Console.WriteLine("         |{0}|    -    |HP : {1}|", ennemy.Name, ennemy.HP);
                Console.WriteLine("        _   ,_,   _\r\n       / `'=) (='` \\\r\n      /.-.-.\\ /.-.-.\\ \r\n      `      \"      `");
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine("");
                }
                Console.WriteLine("                                                                                                          /\\_[]_/\\\r\n                                                                                                         |] _||_ [|\r\n                                                                                                  ___     \\/ || \\/\r\n                                                                                                 /___\\       ||\r\n                                                                                                (|0 0|)      ||\r\n                                                                                              __/{\\U/}\\_ ___/vvv\r\n                                                                                             / \\  {~}   / _|_P|\r\n                                                                                             | /\\  ~   /_/   []\r\n                                                                                             |_| (____)        \r\n                                                                                             \\_]/______\\               \r\n                                                                                                _\\_||_/_           \r\n                                                                                               (_,_||_,_)");
                Console.WriteLine("");
                Console.WriteLine("                                                                                       |{0}|    -    |HP : {1}/{2}|", player.Name, player.HP, player.Max_HP);
                //Display skill
                if(skill1 == true)
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
                            if(player.First_Skill.Name != "None") { choiceSkillOk = true; player.useSkill(ennemy, 1); }
                            else { Console.WriteLine("                       |You don't learn this skill|"); Console.Clear(); }
                        }
                        else if (skill2 == true)
                        {
                            if (player.Second_Skill.Name != "None") { choiceSkillOk = true; player.useSkill(ennemy, 2); }
                            else { Console.WriteLine("                       |You don't learn this skill|"); Console.Clear(); }
                        }
                        else if (skill3 == true)
                        {
                            if (player.Third_Skill.Name != "None") { choiceSkillOk = true; player.useSkill(ennemy, 3); }
                            else { Console.WriteLine("                       |You don't learn this skill|"); Console.Clear(); }
                        }
                        else if (back == true)
                        {
                            choiceSkillOk = true;
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
            Console.WriteLine("             |Vous utiliser votre compétence|");
            Console.ReadKey(true);
            Console.Clear();

        }

        public void choiceBag(Character player)
        {
            Console.Clear();
            Console.WriteLine("                                             ANIMATION DE FOU");
            Console.WriteLine("                                             Tu regarde dans ton sac");
            Console.WriteLine("                                             Ouais ba pour l'instant y a pas vraiment de sac mais on y travail on y est presque donc ça arrive");
            Console.WriteLine("                                             Surement la prochaine étape après MA MAP");
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
