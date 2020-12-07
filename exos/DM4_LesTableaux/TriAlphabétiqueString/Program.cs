using System;

namespace TriAlphabétiqueString
{
    class Program
    {
        static void Main(string[] args)
        {
            //première valeur testé

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("testons en premier cela : ");
            string[] randomList = {"arbre", "bâton", "suif", "joute", "casse", "râler", "narguer", "enuque"};
            foreach(var item in randomList)
            {
                Console.Write(item.ToString());
                Console.Write(", ");
            }   


            string[] orderedList = PutInOrder(randomList);

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("voici la version ordonné : ");
            foreach(var item in orderedList)
            {
                Console.Write(item.ToString());
                Console.Write(", ");
            }
            Console.WriteLine("");
            Console.WriteLine("");


            //seconde valeur testé.

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("bien ! testons ensuite cela : ");
            string[] randomListDeux = {"calamard", "arabe", "anesse", "biscotte", "calamité", "balourd", "croûte", "arable", "bidon" };
            foreach(var item in randomListDeux)
            {
                Console.Write(item.ToString());
                Console.Write(", ");
            }   


            orderedList = PutInOrder(randomListDeux);

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("voici la version ordonné : ");
            foreach(var item in orderedList)
            {
                Console.Write(item.ToString());
                Console.Write(", ");
            }
            Console.WriteLine("");
            Console.WriteLine("");


            //troisième valeur testé.

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("super !! une dernière pour la route ? aller : ");
            string[] randomListTrois = {",programmes(x64)",".programmeFiles(x86)","séisme","Starfoullah","bravissimo","bravo","zoulou","zorro","apre","acre"};
            foreach(var item in randomListTrois)
            {
                Console.Write(item.ToString());
                Console.Write(", ");
            }   


            orderedList = PutInOrder(randomListTrois);

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("voici la version ordonné : ");
            foreach(var item in orderedList)
            {
                Console.Write(item.ToString());
                Console.Write(", ");
            }

            //petite note.
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("note a l'attention de pierre : l'algorithme ici utilisé est un tri a bulle, étudié pour ma part en première et terminale");
            Console.WriteLine("");
        }

        static string[] PutInOrder(string[] orderedList)
        {
            string wordMemory;
            char[] wordSplit;
            char[] wordSplitPlus;

            //trie a bulle, parcours la liste en échangeant de place les éléments dans l'ordre et en répétant l'opération pour i allant de la longueur de la liste - 1 a 1.
            for(int j = orderedList.Length - 1; j > 0; j--)
            {
                for(int i = 0 ; i < orderedList.Length - 1 ; i++)
                {
                    wordSplit = orderedList[i].ToCharArray();
                    wordSplitPlus = orderedList[i+1].ToCharArray();
                    int k = -1;

                    //prend les deux éléments a tester(mis au préalable dans deux tableaux de char) et répète les tests aux caractères suivants en cas de caractères égaux.
                    do
                    {
                        k += 1;
                        if((int)wordSplit[k] > (int)wordSplitPlus[k])
                        {
                            wordMemory = orderedList[i];
                            orderedList[i] = orderedList[i+1];
                            orderedList[i+1] = wordMemory;
                        }
                    }while((int)wordSplit[k] == (int)wordSplitPlus[k]);
                }
            }
            
            return orderedList;
        }
    }
}
