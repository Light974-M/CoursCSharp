using System;

namespace ValidInput
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKey touchesKeep = ConsoleKey.LeftArrow;
            bool isAllowedKeep = false;
            while (!isAllowedKeep)
            {
                isAllowedKeep = ValidInputFunction(touchesKeep);
            }
            Console.WriteLine("Bravo vous savez appuyer sur les touches autorisées :)!");
        }

        static bool ValidInputFunction(ConsoleKey touches)
        {
            bool isAllowed = false;
            switch(touches)
            {
                case ConsoleKey.LeftArrow:
                case ConsoleKey.UpArrow:
                case ConsoleKey.DownArrow:
                case ConsoleKey.RightArrow:
                    isAllowed = true;
                    break;
            }
            return isAllowed;
        }
    }
}
