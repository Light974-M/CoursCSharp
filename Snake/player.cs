using System;

namespace Snake
{
    public struct Player
    {
        private int position;
        private char skinChar;

        public Player(int startPosition)
        {
            position = startPosition;
            skinChar = '0';
        }

        public int GetPosition()
        {
            return position;
        }

        public char GetSkin()
        {
            return skinChar;
        }
    }
}
