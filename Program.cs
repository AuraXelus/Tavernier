using System;
using System.Data;

namespace Tavernier
{
    public class Program
    {
        void create_map()
        {
            map_element elem = new map_element();

            for (int y = 0; y < 20; y++)
            {
                for (int x = 0; x < 20; x++)
                {
                    if (x == elem.player_pos_x && y == elem.player_pos_y)
                        Console.Write(elem.player);
                    else if (x == 0 || x == 19 || y == 0 || y == 19)
                    {
                        Console.Write(elem.wall);

                    }
                    else
                        Console.Write(elem.ground);
                }
                Console.WriteLine();
            }
        }

        public bool valid_move(int x, int y)
        {
            map_element elem = new map_element();

            if (x < 0 || x >= 1 || y < 0 || y >= 20)
                return false;
            if (x == '#' || y == '#')
                return false;

            return true;
        }

        void display_map()
        {
            map_element elem = new map_element();
            while (true)
            {
                ConsoleKey key = Console.ReadKey(true).Key;

                if (key == ConsoleKey.UpArrow)
                {
                    if (valid_move(elem.player_pos_x, elem.player_pos_y - 1))
                        elem.player_pos_y--;
                }
                else if (key == ConsoleKey.DownArrow)
                {
                    if (valid_move(elem.player_pos_x, elem.player_pos_y + 1))
                        elem.player_pos_y++;
                }
                else if (key == ConsoleKey.LeftArrow)
                {
                    if (valid_move(elem.player_pos_x - 1, elem.player_pos_y))
                        elem.player_pos_x--;
                }
                else if (key == ConsoleKey.RightArrow)
                {
                    if (valid_move(elem.player_pos_x + 1, elem.player_pos_x))
                        elem.player_pos_x++;
                }
                Console.Clear();
                create_map();

            }
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            p.create_map();
            p.display_map();
        }
    }
}


/*
 
 
 #############################
 #                           #
 #                           #
 #                           #
 #                           #
 #                           #
 #                           #
 #                           #
 #            P              #
 #                           #
 #                           #
 #                           #
 #                           #
 #                           #
 #                           #
 #                           #
 #                           #
 #############################
 
 
  
 
 */