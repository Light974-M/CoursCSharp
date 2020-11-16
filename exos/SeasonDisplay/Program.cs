using System;

namespace SeasonDisplay
{
    class Program
    {
        static void Main(string[] args)
        {
            //on initialise un booléen Continue qui fait loop ou non le programme,
            //et un entier loop qui sera la valeur saisie par l'utilisateur pour determiner si le programme loop.
            bool Continue = true;
            string loop;

            //tant que Continue est vrai le programme loop.
            while (Continue)
            {

                //aisie utilisateur.
                Console.WriteLine("en quel mois on est ? ");
                string month = Console.ReadLine();

                month = month.ToLower();

                //on teste si la valeur saisie correspond a un mois ou non, et on en déduit la réponse qui sera la saison correspondante.
                if(month == "octobre" || month == "novembre" || month == "décembre")
                {
                    Console.WriteLine("on est en automne, la saison des trucs glauque, la mort arrive qur tout les êtres vivants ayant assez vécu !");
                }

                else if(month == "janvier" || month == "février" || month == "mars")
                {
                    Console.WriteLine("on est en hiver, la saison où les arbres gèlent, et où les tasses chauffent, noël et le vin chaud arrive !");
                }

                else if(month == "avril" || month == "mai" || month == "juin")
                {
                    Console.WriteLine("on est au printemps, les papillons bourgeonnent sur les lauriers en fleur, la saison du renouveau.");
                }

                else if(month == "juillet" || month == "août" || month == "septembre")
                {
                    Console.WriteLine("on est en été, c'est l'heure du cagnar, des bains, et des maillots !");
                }

                else
                {
                    Console.WriteLine("essaye encore...");  
                }

                //saisit utilisateur pour loop, 0 met Continue a false et arrete le programme.
                Console.WriteLine("entrez 0 pour arreter ou continuez");
                loop = Console.ReadLine();
                if(loop == "0")
                {
                    Continue = false;
                }
            }
            
        }
    }
}
