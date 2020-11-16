using System;

namespace CharacterValue
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("tapez un caractère : ");
            ConsoleKeyInfo consoleKeyInf = Console.ReadKey();
            char CharacterRead = consoleKeyInf.KeyChar;
            int valCaracter = CharacterRead;
            Console.WriteLine("vous avez entré : " + CharacterRead + " cela correspond en chiffre à : " + valCaracter);
        }
    }
}
