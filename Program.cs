namespace Tavernier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // personnage nain
            Console.WriteLine("               /\\_[]_/\\\r\n              |] _||_ [|\r\n       ___     \\/ || \\/\r\n      /___\\       ||\r\n     (|0 0|)      ||\r\n   __/{\\U/}\\_ ___/vvv\r\n  / \\  {~}   / _|_P|\r\n  | /\\  ~   /_/   []\r\n  |_| (____)        \r\n  \\_]/______\\               \r\n     _\\_||_/_           \r\n    (_,_||_,_)");

            // ennemis 1
            Console.WriteLine("             _/|    _   |\\_\r\n           _/_ |   _|\\\\ | _\\\r\n         _/_/| /  /   \\|\\ |\\_\\_\r\n       _/_/  |/  /  _  \\/\\|  \\_\\_ \r\n     _/_/    ||  | | \\ / ||    \\_\\_\r\n    /_/  | | |\\  | \\_ V  /| | |  \\_\\\r\n   //    ||| | \\_/   \\__/ | |||    \\\\\r\n  // __| ||\\  \\          /  /|| |__ \\\\\r\n //_/ \\|||| \\/\\\\        //\\/ ||||/ \\_\\\\\r\n///    \\\\\\\\/   /        \\   \\////    \\\\\\\r\n|/      \\/    |    |    |     \\/      \\|\r\n              /_|  | |_  \\\r\n             ///_| |_||\\_ \\\r\n             |//||/||\\/||\\|                                     \r\n              / \\/|||/||/\\/                                  \r\n                /|/\\| \\/                      \r\n                \\/  |      ");

            // ennemis 2
            Console.WriteLine("    _____\r\n    .-,;='';_),-.\r\n     \\_\\(),()/_/\r\n       (,___,)\r\n      ,-/`~`\\-,___\r\n     / /).:.('--._)\r\n    {_[ (_,_)\r\n        | Y |\r\n       /  |  \\\r\n       \"\"\" \"\"\"");

            // personnage elf
            Console.WriteLine("           .-----.\r\n \\ ' /   _/    )/\r\n- ( ) -('---''--)\r\n / . \\((()\\^_^/)()\r\n  \\\\_\\ (()_)-((()()\r\n   '- \\ )/\\._./(()\r\n     '/\\/( X   ) \\\r\n     (___)|___/ ) \\\r\n          |.#_|(___)\r\n         /\\    \\ ( (_\r\n         \\/\\/\\/\\) \\\\\r\n         | / \\ |\r\n         |(   \\|\r\n        _|_)__|_\\_\r\n        )...()...(\r\n         | (   \\ |     \r\n      .-'__,)  (  \\\r\n                '\\_-,");

            // Map
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
                Console.Write("up");
            }

            else if (Console.ReadKey().Key == ConsoleKey.DownArrow)
            {
                Console.Write("down");
                //perso(0, -1);
            }

            else if (Console.ReadKey().Key == ConsoleKey.LeftArrow)
            {
                Console.Write("left");
                //perso(0, -1);
            }

            else if (Console.ReadKey().Key == ConsoleKey.RightArrow)
            {
                Console.Write("right");
                //perso(0, -1);
            }
        }
    }
}