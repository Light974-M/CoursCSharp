using System;

namespace CharacterValue
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("tapez un caractère : ")
            string Caract = Console.ReadLine();
            byte[] asciiBytes = Encoding.ASCII.GetBytes(Caract);
            Console.WriteLine("vous avez entré : " + Caract + " cela correspond en chiffre à : " + asciiBytes);
        }
    }
}
