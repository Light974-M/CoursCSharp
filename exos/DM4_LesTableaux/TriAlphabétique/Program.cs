using System;

namespace TriAlphabétique
{
    class Program
    {
        static void Main(string[] args)
        {
            //créer un alphabet en désordre.
            char[] randomAlphabet = CreateRandomOrderLetters();

            //affiche l'alphabet en désordre.
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("vous avez entrée : ");
            Console.WriteLine(randomAlphabet);

            //appelle la fonction qui remet les lettres en ordre.
            char[] orderedAlphabet = PutInOrder(randomAlphabet);

            //affiche le résultat.
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("voici la version ordonné : ");
            Console.WriteLine(orderedAlphabet);
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("note a l'attention de pierre : l'algorithme ici utilisé est un tri a bulle, étudié pour ma part en première et terminale");
            Console.WriteLine("");
        }

        static char[] CreateRandomOrderLetters()
        {
            //associe l'alphabet en désordre a un tableau char et le retourne.
            char[] randomAlphabet = {'b','a','z','m','e','q','i','j','g','k','p','r','n','c','f','u','y','x','v','t','d','l','w','s','o','h'};
            return randomAlphabet;
        }

        static char[] PutInOrder(char[] orderedAlphabet)
        {
            //déclare une variable qui servira a stocker une valeur du tableau afin d'échanger de place les deux valeurs i et i+1.
            char letterMemory;

            //répète la meme opération pour la longueur du tableau avec i allant de la longueur -1 a 1.
            for(int j = orderedAlphabet.Length - 1; j > 0; j--)
            {
                //opération testant les valeurs adjacentes et les inversant si la valeur de gauche est plus grande pour correspondre a l'ordre.
                for(int i = 0 ; i < orderedAlphabet.Length - 1 ; i++)
                {
                    //si la valeur i(a gauche) est plus grande que la valeur i+1 (droite).
                    if((int)orderedAlphabet[i] > (int)orderedAlphabet[i+1])
                    {
                        //place la valeur i dans la variable de stockage mémoire, puis met la valeur i+1 a l'index i, l'ancienne valeur i est stocké et peut etre réinjecté a l'inde i+1.
                        letterMemory = orderedAlphabet[i];
                        orderedAlphabet[i] = orderedAlphabet[i+1];
                        orderedAlphabet[i+1] = letterMemory;
                    }
                }
            }
            //retourne l'alphabet en ordre.
            return orderedAlphabet;
        }
    }
}
