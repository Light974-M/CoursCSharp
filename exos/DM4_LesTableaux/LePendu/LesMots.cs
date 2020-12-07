using System;

namespace LePendu
{
    public class LesMots
    {
        public static ConsoleKey ChooseDifficulty()
        {
            //detecte l'input 1, 2, et 3 et la retourne.
            ConsoleKeyInfo touche;
            do
            {
                touche = Console.ReadKey();
            }while (touche.Key != ConsoleKey.D1 & touche.Key != ConsoleKey.D2 & touche.Key != ConsoleKey.D3);

            return touche.Key;
        }

        public static string InitRandomWord(string[] banqueDeMotsFacile, string[] banqueDeMotsDifficile, string[] banqueDeMotsAbsurde)
        {
            string choosedWord = "";

            //capte la difficulté et y associe la banque de mot et le nombre d'essais.
            ConsoleKey touche;
            touche = ChooseDifficulty();
            Random rand = new Random();
            if(touche == ConsoleKey.D1)
            {
                choosedWord = banqueDeMotsFacile[(int)rand.Next(0, banqueDeMotsFacile.Length)];
                Program.atempt = 15;
            }

            if(touche == ConsoleKey.D2)
            {
                choosedWord = banqueDeMotsDifficile[(int)rand.Next(0, banqueDeMotsDifficile.Length)];
                Program.atempt = 12;
            }

            if(touche == ConsoleKey.D3)
            {
                choosedWord = banqueDeMotsAbsurde[(int)rand.Next(0, banqueDeMotsAbsurde.Length)];
                Program.atempt = 10;
            }
            
            
            return choosedWord; 
        }
    }
}