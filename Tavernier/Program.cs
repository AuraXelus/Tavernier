﻿using System.Net;
using System.Numerics;
using System.Security.Cryptography;

namespace Tavernier
{
    public class Program
    {
        static char[,] initMap(char[,] map)
        {
            for (int y = 0; y < 25; y++)
            {
                for (int x = 0; x < 50; x++)
                {
                    if (y == 0 || y == 24) { map[y, x] = '#'; }
                    else if (x == 0 || x == 49) { map[y, x] = '#'; }
                    else { map[y, x] = ' '; }
                }
            }
            return map;
        }

        static void run(Player justine, char[,] map)
        {
            ConsoleKey key = Console.ReadKey(true).Key;

            if (key == ConsoleKey.UpArrow)
            {
                if (map[justine.PosX, justine.PosY - 1] != '#') justine.PosY--;
            }
            else if (key == ConsoleKey.DownArrow)
            {
                if (map[justine.PosX, justine.PosY + 1] != '#') justine.PosY++;
            }
            else if (key == ConsoleKey.LeftArrow)
            {
                if (map[justine.PosX - 1, justine.PosY] != '#') justine.PosX--;
            }
            else if (key == ConsoleKey.RightArrow)
            {
                if (map[justine.PosX + 1, justine.PosY] != '#') justine.PosX++;
            }
        }

        static void diplayMap(Player justine, char[,] map)
        {
            for (int y = 0; y < 25; y++)
            {
                for (int x = 0; x < 50; x++)
                {
                    map = initMap(map);
                    if (justine.PosX == x && justine.PosY == y) { map[y, x] = 'P'; }

                    if (y == 0 || y == 24) { Console.Write(map[y, x]); }
                    else if (x == 0 || x == 49) { Console.Write(map[y, x]); }
                    else { Console.Write(map[y, x]); }


                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            bool fin = false;
            char[,] map = new char[25, 50];
            Player justine = new Player();
            map = initMap(map);
            diplayMap(justine, map);
            do
            {
                run(justine, map);
                diplayMap(justine, map);
            } while (fin == false);
        }
    }
}