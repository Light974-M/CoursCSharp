using System;

namespace les_boucles
{
    class Program
    {
        static void Main(string[] args)
        {

            int val;
            val = 0;
            for(int i =0; i < 10; i++)
            {
                Console.WriteLine(i);
            }

           DisplayAllNumbers(25);
           DisplayBy3(7);
           IsPairOrImpair(10);
       
           DisplayAllCharacters(3);
           DisplayTriangle(8);
           DisplayDiamond(10);
        }

        static void DisplayAllNumbers(int number)
        {
            for(int i = 0; i <= number; i++)
            {
                Console.WriteLine(i);
            }
        }

        static void DisplayBy3(int number)
        {
            for(int i = 0; i <= number; i += 3)
            {
                Console.WriteLine(i);
            }
        }

        static void IsPairOrImpair(int number)
        {
            for(int i = 1; i <= number; i++)
            {
                if(i % 2 == 0)
                {
                    Console.WriteLine(i + " est pair");
                }
                else
                {
                    Console.WriteLine(i + " est impair");
                }
                
            }
        }

        static void DisplayAllCharacters(int number)
        {
            
            for(int i = 33; i - 33 <= number; i++)
            {
                int AsciiNumber = Convert.ToInt32(i);
                char CharacterConverted = Convert.ToChar(AsciiNumber);
                Console.WriteLine(CharacterConverted);
            }
        }

        static void DisplayTriangle(int number)
        {
            string astérix = "*";
            
            for(int i = 0; i <= number; i++)
            {
                Console.WriteLine(astérix);
                astérix = astérix + "*";
            }
        }

        static void DisplayDiamond(int number)
        {
            string astérix = "*";
            string asterixMemory = astérix;
            int CountDown = 1;
            int CountUp = 1;
            
            for(int i = 0; i < number; i++)
            {
                astérix = asterixMemory;
                for(int j = 0; j <= number+CountDown; j++)
                {
                    astérix = " " + astérix + " ";
                }
                CountDown -= 1;
                Console.WriteLine(astérix);
                astérix = asterixMemory;
                asterixMemory = asterixMemory + "**";
            }
            CountUp = -3;
            CountDown += 2;

            for(int k = 0; k < number -1; k++)
            {
                astérix = "*";
                for(int l = 0; l <= number+CountUp; l++)
                {
                    astérix = "*" + astérix + "*";
                }

                for(int j = 0; j <= number+CountDown; j++)
                {
                    astérix = " " + astérix + " ";
                }
                CountDown += 1;
                CountUp -= 1;
                Console.WriteLine(astérix);
            }
        }   
    }
}
