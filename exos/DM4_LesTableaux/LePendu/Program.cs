using System;

namespace LePendu
{
    class Program
    {

        //création des trois listes par niveau de difficulté.
        public static string[] banqueDeMotsDifficile = {"canivaux", "tranchant", "piraterie", "batiment", "ordinateur", "poubelle", "ratelier", "plastron", "national", "spherique", "musicien", "assassin", "mercenaire", "chaussure", "bouclier", "carreaux", "symbolique", "claymore", "bottines", "locomotive", "carambar", "amérique", "amerindien", "penalité", "handball", "motocross", "parachute", "ficelles", "incendie", "tabouret", "casquette", "imprimante", "raquette", "pyramide", "elephant", "salamandre", "maximilien", "crocodile", "feuillete", "eucalyptus", "porte-mine",}; 
        public static string[] banqueDeMotsAbsurde = {"llanfairpwllgwyngyllgogerychwyrndrobwllllantysiliogogogoch","scolopendre", "arc-en-ciel", "anticonstitutionnel", "xeroderma pigmentosum", "radicalisation", "photocolometrie", "obligatoirement", "decentralisation", "ideologiquement", "desarticulation", "hendecasyllabes", "hyperboliquement"};
        public static string[] banqueDeMotsFacile = {"pomme", "baton", "soleil", "lune", "choux", "banane", "chaise", "table", "loupe", "navire", "radeau", "pluie", "clou", "niveau", "canal", "chaine", "porte", "pierre", "chat", "chien", "souris", "ilot", "poteau", "alcool", "jarre", "crique", "mars", "venus", "saturn", "train", "jeux", "avion", "tibet", "flute", "piano", "harpe", "montre", "carte", "bonbon", "gants", "lampe", "italie", "", "roue", "trente", "sortie", "batte", "tigre", "ours", "dieu", "beurre", "caisse",}; 
        

        //création de toutes les variables statique.
        public static int atempt;

        static bool isEmpty = false;

        static bool isWon = false;
        static string word;
        static int coup = 0;
        static int gagne = 0;
        static int perdu = 0;

        static string loopInput;
        static bool isLoop = true;
        static void Main(string[] args)
        {
            //écran titre
            Console.WriteLine(@" ____               ______________           _________          ______________     ___         ____     _______             ____       ____ ");
            Console.WriteLine(@"|    |             |              |         |     ___ \__      |              |   |   \       |    |   |       \___        |    |     |    | ");
            Console.WriteLine(@"|    |             |     _________|         |    |   \_  \_    |     _________|   |    \      |    |   |     ___   \_      |    |     |    | ");
            Console.WriteLine(@"|    |             |    |                   |    |     \   \   |    |             |     \     |    |   |    |   \    \     |    |     |    | ");
            Console.WriteLine(@"|    |             |    |                   |    |     |    |  |    |             |      \    |    |   |    |    \    \    |    |     |    | ");
            Console.WriteLine(@"|    |             |    |                   |    |     |    |  |    |             |       \   |    |   |    |    |     |   |    |     |    | ");
            Console.WriteLine(@"|    |             |    |_______            |    |   _/   _/   |    |_______      |    |\  \  |    |   |    |    |     |   |    |     |    | ");
            Console.WriteLine(@"|    |             |            |           |    |__/  __/     |            |     |    | \  \ |    |   |    |    |     |   |    |     |    |   ");
            Console.WriteLine(@"|    |             |     _______|           |     ____/        |     _______|     |    |  \  \|    |   |    |    |     |   |    |     |    | ");
            Console.WriteLine(@"|    |             |    |                   |    |             |    |             |    |   \       |   |    |    |     |   |    |     |    | ");
            Console.WriteLine(@"|    |             |    |                   |    |             |    |             |    |    \      |   |    |    /    /    |    \     /    | ");
            Console.WriteLine(@"|    |__________   |    |_________          |    |             |    |_________    |    |     \     |   |    |___/   _/      \    \___/    /                   ");
            Console.WriteLine(@"|               |  |              |         |    |             |              |   |    |      \    |   |        ___/         \__       __/            ___        ___        ___ ");
            Console.WriteLine(@"|_______________|  |______________|         |____|             |______________|   |____|       \___|   |_______/                \_____/              |___|      |___|      |___| ");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Bienvenu dans le pendu !");
            Console.WriteLine("trouvez les mots proposer soit en testant un mot, soit en entrant une lettre, si la lettre ou le mot entrée correspondent au mot caché, c'est gagné, sinon, vous vous approchez de l'échafaud !");
            Console.WriteLine("trois difficulté s'offre a vous :");

            //boucle du jeu.
            while(isLoop)
            {
                //choix de la difficulté.
                Console.WriteLine("double Pressez la touche...");
                Console.WriteLine(" _                                                 ___                                                      ___                                                                                  ");
                Console.WriteLine($"/ |   -facile, entre 4 et 6 lettres, 15 coups.     ___|    -difficile, entre 8 et 10 lettres, 12 coups.     ___|   -absurde, plus de 10 lettres, 10 coups.                                       gagné : {gagne}");
                Console.WriteLine($" _|_                                              |___                                                      ___|                                                                                 ");
                Console.WriteLine($"                                                                                                                                                                                                 perdu : {perdu}");
                coup = 0; 
                //appelle un mot au hasard en fonction de al difficulté.
                word = LesMots.InitRandomWord( banqueDeMotsFacile, banqueDeMotsDifficile, banqueDeMotsAbsurde);

                //convertit la string en deux tableau de char, dont un servira a cacher le mot.
                char[] wordList = word.ToCharArray();
                char[] wordListHiden = wordList;

                //remplace tout les termes du tableau par des underscore pour cacher le mot, excepté le premier terme.
                for(int i = 1 ; i < wordListHiden.Length ; i++ )
                {
                    wordListHiden[i] = '_';
                }
                wordList = word.ToCharArray();

                Console.WriteLine("\n");
                Console.WriteLine("\n");
                Console.WriteLine("\n");
                Console.WriteLine("\n");
                Console.WriteLine("\n");
                Console.WriteLine("quel est ce mot :" + "\n");

                //récupère la première valeur du tableau et lance le programme qui détectera les mots entré par l'utilisateur, pour la première fois, le char selectionné est le premier du mot pour que le programme affiche par défaut les autres lettres similaire au premier terme.
                string selectedWord = wordList[0].ToString();
                UpdateWord(wordList , wordListHiden, selectedWord);
                //affiche le mot caché avec les éléments trouvé.
                Console.WriteLine(wordListHiden);


                //répète la demande utilisateur tant qu'il reste des essaies et detecte une victoire ou défaite.
                while(atempt > 0 && isWon == false)
                {
                    coup += 1;
                    selectedWord = Console.ReadLine();
                    UpdateWord(wordList , wordListHiden, selectedWord);

                    //affiche le mot seulement si l'utilisateur n'a pas rien entré.
                    if(!isEmpty)
                    {
                        Console.WriteLine(wordListHiden);
                    }
                }
            }
        }



        static void UpdateWord(char[] wordList, char[] wordListHidden, string selectedWord)
        {
            isEmpty = false;
            isWon = true;
            bool isWinning = false;
            char[] selectedWordList = selectedWord.ToCharArray();

            //détecte le cas où le joueur entre un caractère unique.
            if(selectedWordList.Length == 1)
            {
                Char selectedWordChar = char.Parse(selectedWord);

                //parcour la liste et detecte les termes qui correspondent a celui de l'utilisateur, si il n'en trouve pas, il active la phase de défaite du tour.
                for(int i = 0; i < wordList.Length ; i++)
                {
                    if(wordList[i] == selectedWordChar)
                    {
                        wordListHidden[i] = wordList[i];
                        isWinning = true;
                    }

                    if(wordList[i] != wordListHidden[i])
                    {
                        isWon = false;
                    }
                }
            }

            else if(selectedWordList.Length == 0)
            {
                //detecte si le joueur n'entre rien et fait en sorte de mettre en pause le jeu pour que le joueur puisse reprendre juste après.
                isWon = false;
                isWinning = true;
                coup -=1;
                isEmpty = true;
            }

            else
            {
                //s'active si le joueur a entré un mot entier.
                for(int i = 0; i < wordList.Length ; i++)
                {
                    //parcour la liste, si un seul caractère ne correspond pas, il fait perdre le tour, mais si le joueur met le bon mot, il gagne.
                    if(wordList[i] != selectedWordList[i])
                    {
                        isWon = false;
                    }
                }
            }
            

            if(isWinning == false)
            {
                //dans les cas où le joueur perd le tour, chaques phases est représenter graphiquement en fonction des coups restant.
                atempt -= 1;
                if(atempt == 1)
                {
                    Console.WriteLine(@" __________________________________ ");
                    Console.WriteLine(@"|          /                       |");
                    Console.WriteLine(@"|         /                        |");
                    Console.WriteLine(@"|        /                         |");
                    Console.WriteLine(@"|       /                         ___ ");
                    Console.WriteLine(@"|      /                         /- O\");
                    Console.WriteLine(@"|     /                          \_-_/  ");
                    Console.WriteLine(@"|    /                             |      ");
                    Console.WriteLine(@"|   /                             /|\       ");
                    Console.WriteLine(@"|  /                             / | \      ");
                    Console.WriteLine(@"| /                             /  |  \ ");
                    Console.WriteLine(@"|/                                / \    ");
                    Console.WriteLine(@"|\                               /   \   ");
                    Console.WriteLine(@"| \                             /     \  ");
                    Console.WriteLine(@"|  \                                  ");
                    Console.WriteLine(@"|   \         O                             ");
                    Console.WriteLine(@"|    \         \                                 ");
                    Console.WriteLine(@"|_____\_________\_____________________________________");
                }

                if(atempt == 2)
                {
                    Console.WriteLine(@" __________________________________ ");
                    Console.WriteLine(@"|          /                       |");
                    Console.WriteLine(@"|         /                        |");
                    Console.WriteLine(@"|        /                         |");
                    Console.WriteLine(@"|       /                         ___ ");
                    Console.WriteLine(@"|      /                         /O O\");
                    Console.WriteLine(@"|     /                          \_v_/  ");
                    Console.WriteLine(@"|    /                             |      ");
                    Console.WriteLine(@"|   /                             /|\       ");
                    Console.WriteLine(@"|  /                             / | \      ");
                    Console.WriteLine(@"| /                             /  |  \ ");
                    Console.WriteLine(@"|/                                / \    ");
                    Console.WriteLine(@"|\                               /   \   ");
                    Console.WriteLine(@"| \                             /     \  ");
                    Console.WriteLine(@"|  \                                  ");
                    Console.WriteLine(@"|   \                                   ");
                    Console.WriteLine(@"|    \         \                            ");
                    Console.WriteLine(@"|_____\_________\_________________________________");
                }

                if(atempt == 3)
                {
                    Console.WriteLine(@" __________________________________ ");
                    Console.WriteLine(@"|          /                       |");
                    Console.WriteLine(@"|         /                        |");
                    Console.WriteLine(@"|        /                         |");
                    Console.WriteLine(@"|       /                         ___ ");
                    Console.WriteLine(@"|      /                         /O O\");
                    Console.WriteLine(@"|     /                          \_v_/  ");
                    Console.WriteLine(@"|    /                             |      ");
                    Console.WriteLine(@"|   /                             /|\       ");
                    Console.WriteLine(@"|  /                             / | \      ");
                    Console.WriteLine(@"| /                             /  |  \ ");
                    Console.WriteLine(@"|/                                / \    ");
                    Console.WriteLine(@"|\                               /   \   ");
                    Console.WriteLine(@"| \                             /     \  ");
                    Console.WriteLine(@"|  \                                  ");
                    Console.WriteLine(@"|   \                                   ");
                    Console.WriteLine(@"|    \                                      ");
                    Console.WriteLine(@"|_____\___________________________________________");
                }

                if(atempt == 4)
                {
                    Console.WriteLine(@" __________________________________ ");
                    Console.WriteLine(@"|          /                       |");
                    Console.WriteLine(@"|         /                        |");
                    Console.WriteLine(@"|        /                         |");
                    Console.WriteLine(@"|       /                         ___ ");
                    Console.WriteLine(@"|      /                         /O O\");
                    Console.WriteLine(@"|     /                          \_v_/  ");
                    Console.WriteLine(@"|    /                             |      ");
                    Console.WriteLine(@"|   /                             /|\       ");
                    Console.WriteLine(@"|  /                             / | \      ");
                    Console.WriteLine(@"| /                             /  |  \ ");
                    Console.WriteLine(@"|/                                  \    ");
                    Console.WriteLine(@"|\                                   \   ");
                    Console.WriteLine(@"| \                                   \  ");
                    Console.WriteLine(@"|  \                                  ");
                    Console.WriteLine(@"|   \                                   ");
                    Console.WriteLine(@"|    \                                      ");
                    Console.WriteLine(@"|_____\___________________________________________");
                }

                if(atempt == 5)
                {
                    Console.WriteLine(@" __________________________________ ");
                    Console.WriteLine(@"|          /                       |");
                    Console.WriteLine(@"|         /                        |");
                    Console.WriteLine(@"|        /                         |");
                    Console.WriteLine(@"|       /                         ___ ");
                    Console.WriteLine(@"|      /                         /O O\");
                    Console.WriteLine(@"|     /                          \_v_/  ");
                    Console.WriteLine(@"|    /                             |      ");
                    Console.WriteLine(@"|   /                             /|\       ");
                    Console.WriteLine(@"|  /                             / | \      ");
                    Console.WriteLine(@"| /                             /  |  \ ");
                    Console.WriteLine(@"|/                                      ");
                    Console.WriteLine(@"|\                                      ");
                    Console.WriteLine(@"| \                                     ");
                    Console.WriteLine(@"|  \                                  ");
                    Console.WriteLine(@"|   \                                   ");
                    Console.WriteLine(@"|    \                                      ");
                    Console.WriteLine(@"|_____\___________________________________________");
                }

                if(atempt == 6)
                {
                    Console.WriteLine(@" __________________________________ ");
                    Console.WriteLine(@"|          /                       |");
                    Console.WriteLine(@"|         /                        |");
                    Console.WriteLine(@"|        /                         |");
                    Console.WriteLine(@"|       /                         ___ ");
                    Console.WriteLine(@"|      /                         /O O\");
                    Console.WriteLine(@"|     /                          \_v_/  ");
                    Console.WriteLine(@"|    /                             |      ");
                    Console.WriteLine(@"|   /                              |\       ");
                    Console.WriteLine(@"|  /                               | \      ");
                    Console.WriteLine(@"| /                                |  \ ");
                    Console.WriteLine(@"|/                                      ");
                    Console.WriteLine(@"|\                                      ");
                    Console.WriteLine(@"| \                                     ");
                    Console.WriteLine(@"|  \                                  ");
                    Console.WriteLine(@"|   \                                   ");
                    Console.WriteLine(@"|    \                                      ");
                    Console.WriteLine(@"|_____\___________________________________________");
                }

                if(atempt == 7)
                {
                    Console.WriteLine(@" __________________________________ ");
                    Console.WriteLine(@"|          /                       |");
                    Console.WriteLine(@"|         /                        |");
                    Console.WriteLine(@"|        /                         |");
                    Console.WriteLine(@"|       /                         ___ ");
                    Console.WriteLine(@"|      /                         /O O\");
                    Console.WriteLine(@"|     /                          \_v_/  ");
                    Console.WriteLine(@"|    /                             |      ");
                    Console.WriteLine(@"|   /                              |       ");
                    Console.WriteLine(@"|  /                               |       ");
                    Console.WriteLine(@"| /                                |   ");
                    Console.WriteLine(@"|/                                      ");
                    Console.WriteLine(@"|\                                      ");
                    Console.WriteLine(@"| \                                     ");
                    Console.WriteLine(@"|  \                                  ");
                    Console.WriteLine(@"|   \                                   ");
                    Console.WriteLine(@"|    \                                      ");
                    Console.WriteLine(@"|_____\___________________________________________");
                }

                if(atempt == 8)
                {
                    Console.WriteLine(@" __________________________________ ");
                    Console.WriteLine(@"|          /                       |");
                    Console.WriteLine(@"|         /                        |");
                    Console.WriteLine(@"|        /                         |");
                    Console.WriteLine(@"|       /                         ___ ");
                    Console.WriteLine(@"|      /                         /O O\");
                    Console.WriteLine(@"|     /                          \_v_/  ");
                    Console.WriteLine(@"|    /                                   ");
                    Console.WriteLine(@"|   /                                     ");
                    Console.WriteLine(@"|  /                                      ");
                    Console.WriteLine(@"| /                                   ");
                    Console.WriteLine(@"|/                                      ");
                    Console.WriteLine(@"|\                                      ");
                    Console.WriteLine(@"| \                                     ");
                    Console.WriteLine(@"|  \                                  ");
                    Console.WriteLine(@"|   \                                   ");
                    Console.WriteLine(@"|    \                                      ");
                    Console.WriteLine(@"|_____\___________________________________________");
                }

                if(atempt == 9)
                {
                    Console.WriteLine(@" __________________________________ ");
                    Console.WriteLine(@"|          /                       |");
                    Console.WriteLine(@"|         /                        |");
                    Console.WriteLine(@"|        /                         |");
                    Console.WriteLine(@"|       /                         ");
                    Console.WriteLine(@"|      /                         ");
                    Console.WriteLine(@"|     /                            ");
                    Console.WriteLine(@"|    /                                   ");
                    Console.WriteLine(@"|   /                                     ");
                    Console.WriteLine(@"|  /                                      ");
                    Console.WriteLine(@"| /                                   ");
                    Console.WriteLine(@"|/                                      ");
                    Console.WriteLine(@"|\                                      ");
                    Console.WriteLine(@"| \                                     ");
                    Console.WriteLine(@"|  \                                  ");
                    Console.WriteLine(@"|   \                                   ");
                    Console.WriteLine(@"|    \                                      ");
                    Console.WriteLine(@"|_____\___________________________________________");
                }

                if(atempt == 10)
                {
                    Console.WriteLine(@" __________________________________ ");
                    Console.WriteLine(@"|          /                       ");
                    Console.WriteLine(@"|         /                        ");
                    Console.WriteLine(@"|        /                         ");
                    Console.WriteLine(@"|       /                         ");
                    Console.WriteLine(@"|      /                         ");
                    Console.WriteLine(@"|     /                            ");
                    Console.WriteLine(@"|    /                                   ");
                    Console.WriteLine(@"|   /                                     ");
                    Console.WriteLine(@"|  /                                      ");
                    Console.WriteLine(@"| /                                   ");
                    Console.WriteLine(@"|/                                      ");
                    Console.WriteLine(@"|\                                      ");
                    Console.WriteLine(@"| \                                     ");
                    Console.WriteLine(@"|  \                                  ");
                    Console.WriteLine(@"|   \                                   ");
                    Console.WriteLine(@"|    \                                      ");
                    Console.WriteLine(@"|_____\___________________________________________");
                }

                if(atempt == 11)
                {
                    Console.WriteLine(@" __________________________________ ");
                    Console.WriteLine(@"|                                  ");
                    Console.WriteLine(@"|                                  ");
                    Console.WriteLine(@"|                                  ");
                    Console.WriteLine(@"|                                 ");
                    Console.WriteLine(@"|                                ");
                    Console.WriteLine(@"|                                  ");
                    Console.WriteLine(@"|                                        ");
                    Console.WriteLine(@"|                                         ");
                    Console.WriteLine(@"|                                         ");
                    Console.WriteLine(@"|                                     ");
                    Console.WriteLine(@"|                                       ");
                    Console.WriteLine(@"|\                                      ");
                    Console.WriteLine(@"| \                                     ");
                    Console.WriteLine(@"|  \                                  ");
                    Console.WriteLine(@"|   \                                   ");
                    Console.WriteLine(@"|    \                                      ");
                    Console.WriteLine(@"|_____\___________________________________________");
                }

                if(atempt == 12)
                {
                    Console.WriteLine(@" ");
                    Console.WriteLine(@"|                                  ");
                    Console.WriteLine(@"|                                  ");
                    Console.WriteLine(@"|                                  ");
                    Console.WriteLine(@"|                                 ");
                    Console.WriteLine(@"|                                ");
                    Console.WriteLine(@"|                                  ");
                    Console.WriteLine(@"|                                        ");
                    Console.WriteLine(@"|                                         ");
                    Console.WriteLine(@"|                                         ");
                    Console.WriteLine(@"|                                     ");
                    Console.WriteLine(@"|                                       ");
                    Console.WriteLine(@"|\                                      ");
                    Console.WriteLine(@"| \                                     ");
                    Console.WriteLine(@"|  \                                  ");
                    Console.WriteLine(@"|   \                                   ");
                    Console.WriteLine(@"|    \                                      ");
                    Console.WriteLine(@"|_____\___________________________________________");
                }

                if(atempt == 13)
                {
                    Console.WriteLine(@" ");
                    Console.WriteLine(@"|                                  ");
                    Console.WriteLine(@"|                                  ");
                    Console.WriteLine(@"|                                  ");
                    Console.WriteLine(@"|                                 ");
                    Console.WriteLine(@"|                                ");
                    Console.WriteLine(@"|                                  ");
                    Console.WriteLine(@"|                                        ");
                    Console.WriteLine(@"|                                         ");
                    Console.WriteLine(@"|                                         ");
                    Console.WriteLine(@"|                                     ");
                    Console.WriteLine(@"|                                       ");
                    Console.WriteLine(@"|                                       ");
                    Console.WriteLine(@"|                                       ");
                    Console.WriteLine(@"|                                     ");
                    Console.WriteLine(@"|                                       ");
                    Console.WriteLine(@"|                                           ");
                    Console.WriteLine(@"|_________________________________________________");
                }

                if(atempt == 14)
                {
                    Console.WriteLine(@" ");
                    Console.WriteLine(@"                                   ");
                    Console.WriteLine(@"                                   ");
                    Console.WriteLine(@"                                   ");
                    Console.WriteLine(@"                                  ");
                    Console.WriteLine(@"                                 ");
                    Console.WriteLine(@"                                   ");
                    Console.WriteLine(@"                                         ");
                    Console.WriteLine(@"                                          ");
                    Console.WriteLine(@"                                          ");
                    Console.WriteLine(@"                                      ");
                    Console.WriteLine(@"                                        ");
                    Console.WriteLine(@"                                        ");
                    Console.WriteLine(@"                                        ");
                    Console.WriteLine(@"                                      ");
                    Console.WriteLine(@"                                        ");
                    Console.WriteLine(@"                                            ");
                    Console.WriteLine(@"__________________________________________________");
                }
                Console.WriteLine($"Manqué !, il vous reste {atempt} essais.");
            }

            if(atempt == 0)
            {
                Console.WriteLine(@" __________________________________ ");
                Console.WriteLine(@"|          /                       |");
                Console.WriteLine(@"|         /                        |");
                Console.WriteLine(@"|        /                         |");
                Console.WriteLine(@"|       /                         ___ ");
                Console.WriteLine(@"|      /                         /X X\");
                Console.WriteLine(@"|     /                          \_-_/  ");
                Console.WriteLine(@"|    /                             |      ");
                Console.WriteLine(@"|   /                             /|\       ");
                Console.WriteLine(@"|  /                             / | \      ");
                Console.WriteLine(@"| /                             /  |  \ ");
                Console.WriteLine(@"|/                                / \    ");
                Console.WriteLine(@"|\                               /   \   ");
                Console.WriteLine(@"| \                             /     \  ");
                Console.WriteLine(@"|  \                PERDU.....          ");
                Console.WriteLine(@"|   \             O                      ");
                Console.WriteLine(@"|    \           /                          ");
                Console.WriteLine(@$"|_____\_________/________le mot était {word}____________");
                perdu += 1;

                //le joueur a perdu, le programme demande de se looper, sauf si le joueur entre 0 et kill le programme.
                Console.WriteLine("appuyez sur entrée pour recommencer ou entrez 0 pour quitter.");
                loopInput = Console.ReadLine();
                if(loopInput == "0")
                {
                    Console.WriteLine("à bientôt !\n");
                    isLoop = false;
                }

            }


            if(isWon)
            {
                //si le joueur gagne, le message s'affiche avec les coups utilisé et le mot trouvé.
                Console.WriteLine(@"__________                                                      __________          __________________________________           ___________            ________");
                Console.WriteLine(@"\         \                                                    /         /         |                                  |         |           \          |        |");
                Console.WriteLine(@" \         \                  ______________                  /         /          |                                  |         |            \         |        |");
                Console.WriteLine(@"  \         \                /              \                /         /           |       ____________________       |         |             \        |        |");
                Console.WriteLine(@"   \         \              /                \              /         /            |      |                    |      |         |        |\    \       |        |");
                Console.WriteLine(@"    \         \            /                  \            /         /             |      |                    |      |         |        | \    \      |        |");
                Console.WriteLine(@"     \         \          /         /\         \          /         /              |      |                    |      |         |        |  \    \     |        |");
                Console.WriteLine(@"      \         \        /         /  \         \        /         /               |      |                    |      |         |        |   \    \    |        |");
                Console.WriteLine(@"       \         \      /         /    \         \      /         /                |      |                    |      |         |        |    \    \   |        |");
                Console.WriteLine(@"        \         \    /         /      \         \    /         /                 |      |                    |      |         |        |     \    \  |        |");
                Console.WriteLine(@"         \         \  /         /        \         \  /         /                  |      |                    |      |         |        |      \    \ |        |");
                Console.WriteLine(@"          \         \/         /          \         \/         /                   |      |____________________|      |         |        |       \    \|        |");
                Console.WriteLine(@"           \                  /            \                  /                    |                                  |         |        |        \             |");
                Console.WriteLine(@"            \                /              \                /                     |                                  |         |        |         \            |");
                Console.WriteLine(@"             \______________/                \______________/                      |__________________________________|         |________|          \___________|");
                Console.WriteLine(@"");
                Console.WriteLine(@"");
                Console.WriteLine(@"");
                Console.WriteLine(@"");
                Console.WriteLine(@" _______    ________     .        .    _______       ___             ______________ ");
                Console.WriteLine(@"|          |        |    |        |   |       |     |___|           |              |");
                Console.WriteLine(@"|          |        |    |        |   |_______|                     |      " + coup +"       |");
                Console.WriteLine(@"|          |        |    \        /   |              ___            |______________| ");
                Console.WriteLine(@"|_______   |________|     \______/    |             |___|                           ");
                gagne += 1;
                Console.WriteLine("");
                Console.WriteLine($"vous avez trouvé le mot {word}");

                //le joueur a gagné, le programme demande de se looper, sauf si le joueur entre 0 et kill le programme.
                Console.WriteLine("appuyez sur entrée pour recommencer ou entrez 0 pour quitter.");
                loopInput = Console.ReadLine();
                if(loopInput == "0")
                {
                    Console.WriteLine("à bientôt !\n");
                    isLoop = false;
                }
            }
        }
    }
}
