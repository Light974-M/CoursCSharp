using System;

namespace workspace_num
{
    class Program
    {
        static void Main(string[] args)
        {
            JourSemaine jour = JourSemaine.Lundi;
            EstCeQueJeTravail(jour);

        }
        enum JourSemaine
        {
            Lundi,
            Mardi,
            Mercredi,
            Jeudi,
            Vendredi,
            Samedi,
            Dimanche,
        }

        static void EstCeQueJeTravail(JourSemaine jour)
        {
            switch(jour)
            {
                case JourSemaine.Lundi:
                case JourSemaine.Mardi:
                case JourSemaine.Mercredi:
                case JourSemaine.Jeudi:
                case JourSemaine.Vendredi:
                case JourSemaine.Samedi:
                case JourSemaine.Dimanche: 
                    Console.WriteLine("oui je travaille");
                    break;
                default:
                    Console.WriteLine("non je travaille pas");
                    break;

            }
            if(jour ==  JourSemaine.Lundi || jour == JourSemaine.Mardi)
            {
                
            }
        }
    }
}
