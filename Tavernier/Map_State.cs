using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tavernier
{
    public class Map_State
    {
        private string[] text;
        private char[,] _Map;
        private int _Length_Map = 120;
        private int _Height_Map = 29;

        private bool _Fin = false;

        private char _Behind_player = ' ';
        private int _Player_PosX = 1;
        private int _Player_PosY = 1;

        public Map_State() { }

        public void initMap()
        {
            text = File.ReadAllLines("map.txt");
            _Map = new char[_Height_Map, _Length_Map];
            for (int y = 0; y < _Height_Map; y++)
            {
                string line = text[y];
                for (int x = 0; x < _Length_Map; x++)
                {
                    char c = line[x];
                    _Map[y, x] = c;

                }
            }
        }

        public void runMap()
        {
            displayMap();
            do
            {
                movePlayer();
            } while (_Fin == false);
        }

        public void displayMap()
        {
            for (int y = 0; y < _Height_Map; y++)
            {
                for (int x = 0; x < _Length_Map; x++)
                {
                    if (_Player_PosX == x && _Player_PosY == y) Console.Write('P');
                    else Console.Write(_Map[y, x]);
                }
                Console.WriteLine();
            }
        }
        
        public void movePlayer()
        {
            ConsoleKey key = Console.ReadKey(true).Key;
            Console.SetCursorPosition(_Player_PosX, _Player_PosY);
            Console.Write(_Behind_player);
            if (key == ConsoleKey.UpArrow)
            {
                if (_Map[_Player_PosY - 1, _Player_PosX] != '|' && _Map[_Player_PosY - 1, _Player_PosX] != '-') _Player_PosY--;
            }
            else if (key == ConsoleKey.DownArrow)
            {
                if (_Map[_Player_PosY + 1, _Player_PosX] != '|' && _Map[_Player_PosY + 1, _Player_PosX] != '-') _Player_PosY++;
            }
            else if (key == ConsoleKey.LeftArrow)
            {
                if (_Map[_Player_PosY, _Player_PosX - 1] != '|' && _Map[_Player_PosY, _Player_PosX - 1] != '-') _Player_PosX--;
            }
            else if (key == ConsoleKey.RightArrow)
            {
                if (_Map[_Player_PosY, _Player_PosX + 1] != '|' && _Map[_Player_PosY, _Player_PosX + 1] != '-') _Player_PosX++;
            }
            _Behind_player = _Map[_Player_PosY, _Player_PosX];
            Console.SetCursorPosition(_Player_PosX, _Player_PosY);
            Console.Write('P');
        }
    }
}
