using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tavernier
{
    public class Menu_State
    {
        public Menu_State() { }

        public void run(Character player1, Character player2, Character elizendre, Character laevis)
        {
            bool endMenu = false;
            do
            {
                Console.WriteLine("                                                         |MENU|");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("|1-Continue");
                Console.WriteLine("");
                Console.WriteLine("|2-Inventory");
                Console.WriteLine("");
                Console.WriteLine("|3-See your team");
                Console.WriteLine("");
                Console.WriteLine("|4-Save");
                ConsoleKey key = Console.ReadKey(true).Key;
                switch (key)
                {
                    case ConsoleKey.NumPad0:
                        break;
                    case ConsoleKey.NumPad1:
                        endMenu = true;
                        break;
                    case ConsoleKey.NumPad2:
                        displayInventory();
                        break;
                    case ConsoleKey.NumPad3:
                        displayTeam(player1, player2);
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
                Console.SetCursorPosition(0,0) ;
            } while (endMenu == false);
        }

        public void displayInventory()
        {
            Console.WriteLine("                                                         |INVENTORY|");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("|Heal potion : {0}", 0);
            Console.WriteLine("");
            Console.WriteLine("|SP potion : {0}", 0);
            Console.WriteLine("");
            Console.WriteLine("|Buff : {0}", 0);
            Console.ReadKey(true);
            Console.Clear();
        }

        public void displayTeam(Character balfis, Character player2)
        {
            Console.Clear();
            Console.WriteLine("                                                         |TEAM|");
            Console.WriteLine("|{0}", balfis.Name);
            Console.WriteLine();
            Console.WriteLine("|{0}/{1}", balfis.HP ,balfis.Max_HP);
            Console.ReadKey(true);
        }

    }
}
