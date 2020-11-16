using System;

namespace Helper
{
    public class HelperInput
    {
        public static int ReadInt(string displayContent = "Enter a integer : ")
        {
            int readInput = 0; 
            bool isInputNotValid = true;

            while(isInputNotValid)
            {
                Console.WriteLine(displayContent);
                string entry = Console.ReadLine();

                try
                {
                    readInput = int.Parse(entry);
                    isInputNotValid = false;
                }
                catch(Exception exception)
                {
                    isInputNotValid = true;
                    Console.WriteLine($"{entry} is not valid for a integer ! Error : {exception.GetType()} ");
                }
            }

            return readInput;
        }

        public static int ReadInt(int min, int max, string displayContent = "Enter an integer")
        {
            int entry = 0;
            bool isOutOfrange = true;

            while(isOutOfrange)
            {
                entry = ReadInt($"enter an integer");


            }
            return 0;
        }

        public static float ReadFloat(string displayContent = "enter a float")
        {
            float ReadFloat = 0.1f;
            bool floatIsNotValid = true;
            while(floatIsNotValid)
            {
                Console.WriteLine(displayContent);
                string entry = Console.ReadLine();

                bool parseWorkOrNot = float.TryParse(entry, out readFloat);

            }
            return ReadFloat;
        }

        
        /*public static int ReadInt(int min, int max, string displayContent = "Enter a integer : ")
        {
            return ReadInt(displayContent);
        }*/
    }
}