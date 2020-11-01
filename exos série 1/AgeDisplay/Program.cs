using System;

namespace AgeDisplay
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenue sur notre programme, tapez votre nom : ");
            string userName = Console.ReadLine();
            Console.WriteLine("Bonjour " + userName + " ! ");
            Console.WriteLine("veuillez entrer votre âge : ");
            string userAge = Console.ReadLine();
            int AgeInt = int.Parse(userAge);
            int WhenBorn = 2020 - AgeInt;
            Console.WriteLine("Bonjour " + userName + " ! ");
            Console.WriteLine("je sait quand vous etes né, en l'an " + WhenBorn + " car vous avez " + AgeInt);
        }
    }
}
