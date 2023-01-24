using System;

namespace Tavernier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Char perso = 'P';

            Console.Write("###############################################################\n");


            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write("#                                                             #\n");
                }
            }
            Console.Write("###############################################################\n");

            if (Console.ReadKey().Key == ConsoleKey.UpArrow)
            {
                Console.Write(perso);
            }

            //else if (Console.ReadKey().Key == ConsoleKey.DownArrow)
            //{
            //    perso(0, -1);
            //}

            //else if (Console.ReadKey().Key == ConsoleKey.LeftArrow)
            //{
            //    perso(0, -1);
            //}

            //else if (Console.ReadKey().Key == ConsoleKey.RightArrow)
            //{
            //    perso(0, -1);
            //}

        }
    }
}