using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tavernier
{
    public class Player
    {
        private char playerChar = 'P';
        private int posX = 1;
        private int posY = 1;

        public Player() { }

        public char PlayerChar { get => playerChar; set => playerChar = value; }
        public int PosX { get => posX; set => posX = value; }
        public int PosY { get => posY; set => posY = value; }
    }
}