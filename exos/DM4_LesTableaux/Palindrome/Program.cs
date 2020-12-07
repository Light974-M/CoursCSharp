using System;

namespace Palindrome
{
    class Program
    {
        //initialisation ds variables de bouclage, d'input, et de liste.
        static bool isPalindrome = true;
        static char[] palindromeListe;
        static char[] palindromeListeSansEspace;
        static bool isLoop = true;
        static string looping;
        static int indexSansEspace = 0;
        static void Main(string[] args)
        {
            
            string palindrome;
            //début de la boucle principale du programme.
            while(isLoop)
            {
                //demande a l'utilisateur d'entrer un mot ou une phrase.
                Console.WriteLine("entrez une phrase : ");
                palindrome = Console.ReadLine();

                TestDuPalindrome(palindrome);
            }
        }

        static void TestDuPalindrome(string palindrome)
        {
            //la string dont la longueur sera celle du mot entré sans les espaces.
            string numberWithoutSpace = "";

            //la détection du palindrome est mise par défaut sur true et balance est initialisé.
            isPalindrome = true;

            //retire les majuscules de la string.
            palindrome = palindrome.ToLower();

            //converti l'input en un tableau de char.
            palindromeListe = palindrome.ToCharArray();

            //une première boucle compte les nombre de char sans espaces et retranscrit dans une string.
            for(int k = 0; k< palindromeListe.Length; k++)
            {
                if(palindromeListe[k] != ' ')
                {
                    numberWithoutSpace += "1";
                }
            }

            //la string se converti en tableau de char dans palindrome sans espace.
            palindromeListeSansEspace = numberWithoutSpace.ToCharArray();

            //un index bis est appellé, qui sera un inde n'avancant de 1 que si la valeur parcouru n'est pas un espace.
            indexSansEspace = 0;

            //parcour une seconde fois la liste original en associant terme a terme a la nouvelle liste en excluant les espaces.
            for(int j = 0; j< palindromeListe.Length; j++)
            {
                if(palindromeListe[j] != ' ')
                {
                    palindromeListeSansEspace[indexSansEspace] = palindromeListe[j]; 
                    indexSansEspace += 1;
                }
            }

            //parcours toute la liste une dernière fois et y teste le palindrome.
            for(int i = 0; i< palindromeListeSansEspace.Length; i++)
            {

                //teste l'inégalité des valeurs du tableau parcouru avec leurs homologue parcouru dans l'autre sens.
                if(palindromeListeSansEspace[i] != palindromeListeSansEspace[palindromeListeSansEspace.Length - (i + 1)])
                {
                    isPalindrome = false;
                }
            }

            //teste si le booléen isPalindrome est toujours égal a true et affiche le résultat.
            if(isPalindrome)
            {
                Console.WriteLine("bravo ! c'est un palindrome !");
            }
            else
            {
                Console.WriteLine("non, ce n'est pas un palindrome...");
            }


            //fait boucler le programme.
            
            Console.WriteLine("appuyez sur entrée pour continuer, ou tapez 0 pour quitter.");
            looping = Console.ReadLine();

            if(looping == "0")
            {
                Console.WriteLine("à bientot !");
                isLoop = false;
            }
        }
    }
}
