using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Tavernier
{
    public class Menu_State
    {
        public Menu_State() { }

        public void run(Character balfis, Character nina, Character elizendre, Character laevis)
        {
            bool endMenu = false;
            Console.Clear();
            do
            {
                Console.WriteLine("                                                         |MENU|");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("|1-Continue");
                Console.WriteLine("");
                Console.WriteLine("|2-Inventory");
                Console.WriteLine("");
                Console.WriteLine("|3-My team");
                Console.WriteLine("");
                Console.WriteLine("|4-Save");
                ConsoleKey key = Console.ReadKey(true).Key;
                switch (key)
                {
                    case ConsoleKey.NumPad0:
                        break;

                    case ConsoleKey.NumPad1:
                    case ConsoleKey.A:
                        endMenu = true;
                        break;

                    case ConsoleKey.NumPad2:
                    case ConsoleKey.Z:
                        displayInventory();
                        break;

                    case ConsoleKey.NumPad3:
                    case ConsoleKey.E:

                        Console.WriteLine("                                                         |TEAM|");
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("|1-Team stats");
                        Console.WriteLine("");
                        Console.WriteLine("|2-Skills");
                        Console.WriteLine("");
                        Console.WriteLine("|3-Weapons");

                        ConsoleKey Tkey = Console.ReadKey(true).Key;

                        if (Tkey == ConsoleKey.NumPad1 || Tkey == ConsoleKey.A)
                        {
                            displayTeamStats(balfis, nina, elizendre, laevis);
                        }

                        else if (Tkey == ConsoleKey.NumPad2 || Tkey == ConsoleKey.Z)
                        {
                            displaySkills(balfis, nina, elizendre, laevis);
                        }

                        else if (Tkey == ConsoleKey.NumPad3 || Tkey == ConsoleKey.E)
                        {
                            displayWeapons(balfis, nina, elizendre, laevis);
                        }

                        break;

                    case ConsoleKey.NumPad4:
                        break;

                    default:
                        break;
                }
                Console.SetCursorPosition(0, 0);
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

        public void displayTeamStats(Character balfis, Character elizendre, Character laevis, Character nina)
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

        public void displaySkills(Character balfis, Character elizendre, Character laevis, Character nina)
        {
            Console.Clear();
            Console.WriteLine("                                                        |SKILLS|");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("       |{0}|                       |{1}|                      |{2}|                         |{3}|", balfis.Name, elizendre.Name, laevis.Name, nina.Name);
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("       |{0}|                      |{1}|                    |{2}|                |{3}|", balfis.First_Skill.Name, elizendre.First_Skill.Name, laevis.First_Skill.Name, nina.First_Skill.Name);
            Console.WriteLine("");
            Console.WriteLine("Cost | {0}                       Cost | {1}                       Cost | {2}                       Cost | {3}", balfis.First_Skill.Point_SP, elizendre.First_Skill.Point_SP, laevis.First_Skill.Point_SP, nina.First_Skill.Point_SP);
            Console.WriteLine("----------------------          ----------------------          ----------------------          ----------------------");
            Console.WriteLine("Physical damage | {0}           Elemental damage | {1}          Physical damage | {2}           Elemental damage | {3}", balfis.First_Skill.Modif_dmg, elizendre.First_Skill.Modif_dmg, laevis.First_Skill.Modif_dmg, nina.First_Skill.Modif_dmg);
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("     |{0}|                      |{1}|                     |{2}|                  |{3}|", balfis.Second_Skill.Name, elizendre.Second_Skill.Name, laevis.Second_Skill.Name, nina.Second_Skill.Name);
            Console.WriteLine("");
            Console.WriteLine("Cost | {0}                       Cost | {1}                       Cost | {2}                       Cost | {3}", balfis.Second_Skill.Point_SP, elizendre.Second_Skill.Point_SP, laevis.Second_Skill.Point_SP, nina.Second_Skill.Point_SP);
            Console.WriteLine("----------------------          ----------------------          ----------------------          ----------------------");
            Console.WriteLine("Physical damage | {0}            Elemental damage | {1}          Elemental damage | {2}          Physical damage | {3}", balfis.Second_Skill.Modif_dmg, elizendre.Second_Skill.Modif_dmg, laevis.Second_Skill.Modif_dmg, nina.Second_Skill.Modif_dmg);
            Console.ReadKey(true);
            Console.Clear();
        }

        public void displayWeapons(Character balfis, Character elizendre, Character laevis, Character nina)
        {
            Console.Clear();
            Console.WriteLine("                                                        |WEAPONS|");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("       |{0}|                       |{1}|                      |{2}|                         |{3}|", balfis.Name, elizendre.Name, laevis.Name, nina.Name);
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("   |{0}|                  |{1}|                  |{2}|                  |{3}|", balfis.First_Weapon.Name, elizendre.First_Weapon.Name, laevis.First_Weapon.Name, nina.First_Weapon.Name);
            Console.WriteLine("");
            Console.WriteLine("Type | Strike                   Type | Slash                    Type | Slash                    Type | Slash");
            Console.WriteLine("----------------------          ----------------------          ----------------------          ----------------------");
            Console.WriteLine("Physical damage | {0}            Physical damage | {1}             Elemental damage | {2}           Physical damage | {3}", balfis.First_Weapon.Phy_Atk, elizendre.First_Weapon.Phy_Atk, laevis.First_Weapon.Elem_Atk, nina.First_Weapon.Phy_Atk);
            Console.WriteLine("----------------------          ----------------------          ----------------------          ----------------------");
            Console.WriteLine("                                Elemental damage | {0}                                           Elemental damage | {1}", elizendre.First_Weapon.Elem_Atk, nina.First_Weapon.Elem_Atk);
            Console.ReadKey(true);
            Console.Clear();
        }
    }
}
