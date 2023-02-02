using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tavernier
{
    internal class Team_Menu
    {
        public Team_Menu() { }

        public void run(Player balfis, Player elizendre, Player laevis, Player nina, Skill Sbalfis, Skill Selizendre, Skill Slaevis, Skill Snina)
        {
            bool endMenu = false;
            do
            {
                Console.WriteLine("                                                         |TEAM|");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("|1-Team stats");
                Console.WriteLine("");
                Console.WriteLine("|2-Skills");
                ConsoleKey key = Console.ReadKey(true).Key;
                switch (key)
                {
                    case ConsoleKey.NumPad0:
                        break;
                    case ConsoleKey.NumPad1:
                        displayTeam(balfis, elizendre, laevis, nina);
                        break;
                    case ConsoleKey.NumPad2:
                        displaySkills(Sbalfis, Selizendre, Slaevis, Snina);
                        break;
                    case ConsoleKey.NumPad3:
                        break;
                    case ConsoleKey.NumPad4:
                        break;
                    case ConsoleKey.NumPad5:
                        break;
                    case ConsoleKey.NumPad6:
                        break;
                    case ConsoleKey.NumPad7:
                        break;
                    case ConsoleKey.NumPad8:
                        break;
                    case ConsoleKey.NumPad9:
                        break;
                    default:
                        break;
                }
                Console.SetCursorPosition(0, 0);
            } while (endMenu == false);
        }

        public void displayTeam(Player balfis, Player elizendre, Player laevis, Player nina)
        {
            Console.Clear();
            Console.WriteLine("    |{0}| lvl. {1}               |{2}| lvl. {3}              |{4}| lvl. {5}                 |{6}| lvl. {7}", balfis.Name, balfis.Lvl, elizendre.Name, elizendre.Lvl, laevis.Name, laevis.Lvl, nina.Name, nina.Lvl);
            Console.WriteLine("");
            Console.WriteLine("                                                        |GENERAL|");
            Console.WriteLine("Elemental type | {0}          Elemental type | {1}           Elemental type | {2}        Elemental type | {3}", balfis.Elem_Type, elizendre.Elem_Type, laevis.Elem_Type, nina.Elem_Type);
            Console.WriteLine("------------------------       ------------------------       ------------------------       ------------------------");
            Console.WriteLine("HP | {0}/{1}                   HP | {2}/{3}                   HP | {4}/{5}                   HP | {6}/{7}", balfis.HP, balfis.Max_HP, elizendre.HP, elizendre.Max_HP, laevis.HP, laevis.Max_HP, nina.HP, nina.Max_HP);
            Console.WriteLine("------------------------       ------------------------       ------------------------       ------------------------");
            Console.WriteLine("SP | {0}/{1}                     SP | {2}/{3}                   SP | {4}/{5}                   SP | {6}/{7}", balfis.SP, balfis.Max_SP, elizendre.SP, elizendre.Max_SP, laevis.SP, laevis.Max_SP, nina.SP, nina.Max_SP);
            Console.WriteLine("------------------------       ------------------------       ------------------------       ------------------------");
            Console.WriteLine("Accuracy | {0}                  Accuracy | {1}                  Accuracy | {2}                  Accuracy | {3}", balfis.Accuracy, elizendre.Accuracy, laevis.Accuracy, nina.Accuracy);
            Console.WriteLine("------------------------       ------------------------       ------------------------       ------------------------");
            Console.WriteLine("Speed | {0}                     Speed | {1}                     Speed | {2}                     Speed | {3}", balfis.Speed, elizendre.Speed, laevis.Speed, nina.Speed);
            Console.WriteLine("");
            Console.WriteLine("                                                        |DAMAGE|");
            Console.WriteLine("Physical damage | {0}           Physical damage | {1}           Physical damage | {2}           Physical damage | {3}", balfis.Phys_Atk, elizendre.Phys_Atk, laevis.Phys_Atk, nina.Phys_Atk);
            Console.WriteLine("------------------------       ------------------------       ------------------------       ------------------------");
            Console.WriteLine("Elemental damage | {0}          Elemental damage | {1}          Elemental damage | {2}          Elemental damage | {3}", balfis.Elem_Atk, elizendre.Elem_Atk, laevis.Elem_Atk, nina.Elem_Atk);
            Console.WriteLine("");
            Console.WriteLine("                                                        |DEFENSE|");
            Console.WriteLine("Physical defense | {0}          Physical defense | {1}          Physical defense | {2}           Physical defense | {3}", balfis.Phys_Def, elizendre.Phys_Def, laevis.Phys_Def, nina.Phys_Def);
            Console.WriteLine("------------------------       ------------------------       ------------------------       ------------------------");
            Console.WriteLine("Elemental defense | {0}         Elemental defense | {1}         Elemental defense | {2}         Elemental defense | {3}", balfis.Elem_Def, elizendre.Elem_Def, laevis.Elem_Def, nina.Elem_Def);
            Console.WriteLine("");
            Console.WriteLine("                                                        |CRITICAL|");
            Console.WriteLine("Critical probability | {0}       Critical probability | {1}       Critical probability | {2}       Critical probability | {3}", balfis.Critical_Chance, elizendre.Critical_Chance, laevis.Critical_Chance, nina.Critical_Chance);
            Console.WriteLine("------------------------       ------------------------       ------------------------       ------------------------");
            Console.WriteLine("Critical damage | {0}            Critical damage | {1}            Critical damage | {2}            Critical damage | {3}", balfis.Critical_Puiss, elizendre.Critical_Puiss, laevis.Critical_Puiss, nina.Critical_Puiss);
            Console.ReadKey(true);
            Console.Clear();
        }

        public void displaySkills(Skill Sbalfis, Skill Selizendre, Skill Slaevis, Skill Snina)
        {
            Console.Clear();
            Console.WriteLine("    |{0}|               |{2}|              |{4}|                 |{6}|", Sbalfis.Name, Selizendre.Name, Slaevis.Name, Snina.Name);
            Console.WriteLine("------------------------       ------------------------       ------------------------       ------------------------");
            Console.WriteLine("    {0} | SP {1}               {2} | SP {3}              {4} | SP {5}                 {6} | SP {7}", Sbalfis.Name, Sbalfis.Point_SP, Selizendre.Name, Selizendre.Point_SP, Slaevis.Name,Slaevis.Point_SP, Snina.Name, Snina.Point_SP);


            Console.ReadKey(true);
            Console.Clear();
        }
    }
}