using System;

namespace fonctions
{
    class Program
    {
        static void Main(string[] args)
        {
            /*string message = Console.ReadLine();
            int age = int.Parse(message);
            DisplayAge(age);
            Console.WriteLine("votre age est de : " + age);
            */
            CalculeTVA(1200, 2, 20,"RTX 3080");
            CalculeTVA(60, 12, 30,"bonsaï");
            ConvertAscii('b');
            ConvertAscii('#');
            DisplayMonth("janvier");
            DisplayMonth("octobre");
            ChineseZodiaque(2020);
            ChineseZodiaque(1543);
            ChineseZodiaque(2002);
            ChineseZodiaque(2005);
            Moyenne(43,54,2);
            LifeState(100,true,false,50);
            Rectangle(12,6.3);
            Tesseract(3, 4.6, 8, 2);
            Pourcent(340,1245);
            AgeDetermine(18);
        }


        static void DisplayAge(int age)
        {
            age += 1;
            Console.WriteLine("votre age est de : " + age);
        }

        static void CalculeTVA(double PrixProduit1, int Quantité1, double TVA, string ProductName)
        {
            double PrixDeBase1 = PrixProduit1 * Quantité1;

            double PrixTTC1 = PrixDeBase1 * (1+(TVA/100));

            Console.WriteLine("Nom du produit : RTX 3080");
            Console.WriteLine("prix de base : " + PrixDeBase1);
            Console.WriteLine("prixTTC : " + PrixTTC1);
        }

        static void ConvertAscii(char CharacterRead)
        {
            int valCharacter = CharacterRead;
            Console.WriteLine(CharacterRead + " = " + valCharacter);
        }

        static void DisplayMonth(string month)
        {
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
        }

        static void ChineseZodiaque(int BirthYear)
        {
            if((4 - BirthYear) % 12 == 0)
            {
                Console.WriteLine("RAT !");
            }

            if((5 - BirthYear) % 12 == 0)
            {
                Console.WriteLine("BOEUF !");
            }

             if((6 - BirthYear) % 12 == 0)
            {
                Console.WriteLine("TIGRE !");
            }

             if((7 - BirthYear) % 12 == 0)
            {
                Console.WriteLine("LAPIN !");
            }

             if((8 - BirthYear) % 12 == 0)
            {
                Console.WriteLine("DRAGON !");
            }

             if((9 - BirthYear) % 12 == 0)
            {
                Console.WriteLine("SERPENT !");
            }

             if((10 - BirthYear) % 12 == 0)
            {
                Console.WriteLine("CHEVAL !");
            }

             if((11 - BirthYear) % 12 == 0)
            {
                Console.WriteLine("MOUTON !");
            }

            if((BirthYear) % 12 == 0)
            {
                Console.WriteLine("SINGE !");
            }

            if((1 - BirthYear) % 12 == 0)
            {
                Console.WriteLine("COQ !");
            }

            if((2 - BirthYear) % 12 == 0)
            {
                Console.WriteLine("CHIEN !");
            }

            if((3 - BirthYear) % 12 == 0)
            {
                Console.WriteLine("COCHON !");
            }
        }

        static void Moyenne(double Val1,double Val2, int NombreElements)
        {
            Console.WriteLine((Val1+Val2)/NombreElements);
        }

        static void LifeState(byte life, bool isHurtable, bool isInvincible, byte damages)
        {
             Console.WriteLine("Life Bob is : " + life + " and his state invicible is : " + isInvincible);
            if( life > 0 && isHurtable)
            {
                life -= damages;
            }
            Console.WriteLine("Life Bob is : " + life + " and his state invicible is : " + isInvincible);

            isInvincible = true;            
            if( life > 0 && !isInvincible)
            {
                life -= damages;
            }
            Console.WriteLine("Life Bob is : " + life + " and his state invicible is : " + isInvincible);
        }

        static void Rectangle(double Largeur,double Longueur)
        {
            Console.WriteLine(Largeur*Longueur);
        }

        static void Tesseract(double Longueur, double Largeur, double Profondeur, double QuatriemeDimension)
        {
            double Surface = 24 *(Longueur*Largeur);
            double Volume = 8 * (Longueur * Largeur * Profondeur);
            double Volume4 = (Longueur * Largeur * Profondeur * QuatriemeDimension);
            Console.WriteLine("Surface : " + Surface + "m²");
            Console.WriteLine("Volume : " + Volume + "m³");
            Console.WriteLine("Dimensions total(volume quatre) : " + Volume4 + "m⁴");
        }

        static void Pourcent(double Valeur,double ValeurMax)
        {
            Console.WriteLine(Valeur + " vaut " + 100*(Valeur/ValeurMax) + "% de : " + ValeurMax);
        }

        static void AgeDetermine(int AgeInt)
        {
            int WhenBorn = 2020 - AgeInt;
            Console.WriteLine("je sait quand vous etes né, en l'an " + WhenBorn + " car vous avez " + AgeInt + " ans");
            if(AgeInt >= 18)
            {
                Console.WriteLine("VOUS ETES MAJEUR");
            }

            if(AgeInt < 18)
            {
                Console.WriteLine("VOUS ETES MINEUR");
            }
        }
    }
}