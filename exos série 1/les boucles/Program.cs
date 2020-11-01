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
            string astérix = "";
            
            for(int i = 0; i <= number; i++)
            {
                astérix = astérix + "*";
            }

            for(int i = 0; i <= number; i++)
            {
                astérix = " " + astérix;
            }
        }
    }
}
