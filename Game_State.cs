using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tavernier
{
    internal class Game_State
    {
        public Game_State() 
        {
            
        }

        public void run(Character player, Character ennemy)
        {
            do
            {
                display(player, ennemy);
                Console.ReadKey();
            } while (player.Alive == true && ennemy.Alive == true);
        }

        public void display(Character player, Character ennemy)
        {
            Console.WriteLine("         |{0}|    -    |HP : {1}|", ennemy.Name, ennemy.HP);
            Console.WriteLine("        _   ,_,   _\r\n       / `'=) (='` \\\r\n      /.-.-.\\ /.-.-.\\ \r\n      `      \"      `");
            for (int i = 0;i < 5; i++) 
            {
                Console.WriteLine("");
            }
            Console.WriteLine("                                                                                                          /\\_[]_/\\\r\n                                                                                                         |] _||_ [|\r\n                                                                                                  ___     \\/ || \\/\r\n                                                                                                 /___\\       ||\r\n                                                                                                (|0 0|)      ||\r\n                                                                                              __/{\\U/}\\_ ___/vvv\r\n                                                                                             / \\  {~}   / _|_P|\r\n                                                                                             | /\\  ~   /_/   []\r\n                                                                                             |_| (____)        \r\n                                                                                             \\_]/______\\               \r\n                                                                                                _\\_||_/_           \r\n                                                                                               (_,_||_,_)");
            Console.WriteLine("");
            Console.WriteLine("                                                                                           |{0}|    -    |HP : {1}|", player.Name, player.HP);
        }
    }
}
                                           