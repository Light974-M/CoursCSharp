using System;

namespace Snake
{
    public struct  Level
    {
        private static char lineReturnChar = '\n';
        private static char emptyChar = ' ';
        private static char skinWallHori = '_';
        private static char skinWallVert = '|';

        private int width;
        private int height;
        private char[] grid;

        public Level(int width, int height)
        {
            this.width = width;
            this.height = height;
            grid = new char[width * height];

            skinWallHori = '_';
            skinWallVert = '|';

            for(int i = 0; i < grid.Length; i++)
            {
                grid[i] = emptyChar;
            }

            //InitTabRandom();
        }

        public int GetCenterLevelPosition()
        {
            int i = height /2;
            int j = width /2;
            return CalculIndexFromPos(i, j);
        }

        private int CalculIndexFromPos(int linePos, int rowPos)
        {
            return rowPos + linePos * width;
        }
        private void InitTabRandom()
        {
            Random rand = new Random();
            for(int i = 0; i < grid.Length; i++)
            {
                grid[i] = (char)rand.Next(33, 150);
            }
        }

        public string ToStringLevel()
        {
            string gridContent = "";
            gridContent += CreateLineWithChar(width, skinWallHori);

            for(int i = 0; i<height; i++)
            {
                gridContent += lineReturnChar.ToString() + skinWallVert;
                for(int j = 0; j < width; j++)
                {
                    gridContent += grid[j + i * width];
                }
                gridContent += skinWallVert; 
            }
            gridContent += lineReturnChar + CreateLineWithChar(width + 2, skinWallHori);
            return gridContent;
        }

        private string CreateLineWithChar(int numberChar, char charToDisplay)
        {
            string line = "";
            for(int i = 0 ; i < numberChar; i++)
            {
                line += charToDisplay;
            }
            return line;
        }

        public void UpdateGrid(int indexPos, char charReplace)
        {
            
            grid[indexPos] = charReplace;
        }
    }
}