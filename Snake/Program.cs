using System;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Level level = new Level(60,15);

            int startPos = level.GetCenterLevelPosition();

            Player player = new Player(startPos);

            level.UpdateGrid(player.GetPosition(), player.GetSkin());

            Console.WriteLine(level.ToStringLevel());
        }
    }
}
