using System;

namespace MonthToColor
{
    class Program
    {
        enum Month
        {
            January,
            February,
            March,
            April,
            May,
            June,
            July,
            August,
            September,
            October,
            November,
            December,
        }

        enum Season
        {
            Spring,
            Autumn,
            Winter,
            Print,
        }

        enum Color
        {
            White,
            Green,
            Yellow,
            Red,
        }

        static void Main(string[] args)
        {
            Month monthKeep;
            Season seasonKeep;
            Color colorKeep;
            Console.WriteLine("what month is it ?");
            string monthTape = Console.ReadLine();
            monthTape = monthTape.ToLower();
            monthKeep = MonthTransform(monthTape);
            seasonKeep = SeasonTransform(monthKeep);
            colorKeep = ColorTransform(seasonKeep);
            Console.WriteLine($"Le mois de {monthKeep} appartient à la saison {seasonKeep} et sa couleur est le {colorKeep}.");
            
        }

        static Month MonthTransform(string monthTape)
        {
            Month month = Month.January;

            switch(monthTape)
            {
                case "january":
                    month = Month.January;
                    break;
                case "february":
                    month = Month.February;
                    break;
                case "march":
                    month = Month.March;
                    break;
                case "april":
                    month = Month.April;
                    break;
                case "may":
                    month = Month.May;
                    break;
                case "june":
                    month = Month.June;
                    break;
                case "july":
                    month = Month.July;
                    break;
                case "august":
                    month = Month.August;
                    break;
                case "september":
                    month = Month.September;
                    break;
                case "october":
                    month = Month.October;
                    break;
                case "november":
                    month = Month.November;
                    break;
                case "december":
                    month = Month.December;
                    break;
                default :
                    Console.WriteLine("That's a wrong month, try again !");
                    break;
            }
            return month;
        }

        static Season SeasonTransform(Month month)
        {
            Season season = Season.Print;

            switch(month)
            {
                case Month.January:
                case Month.February:
                case Month.March:
                    season = Season.Winter;
                    break;
                case Month.April:
                case Month.May:
                case Month.June:
                    season = Season.Print;
                    break;
                case Month.July:
                case Month.August:
                case Month.September:
                    season = Season.Spring;
                    break;
                case Month.October:
                case Month.November:
                case Month.December:
                    season = Season.Autumn;
                    break;
            }
            return season;
        }

        static Color ColorTransform(Season season)
        {
            Color color = Color.Green;

            switch(season)
            {
                case Season.Winter:
                    color = Color.White;
                    break;
                case Season.Spring:
                    color = Color.Yellow;
                    break;
                case Season.Print:
                    color = Color.Green;
                    break;
                case Season.Autumn:
                    color = Color.Red;
                    break;
            }
            return color;
        }
        
    }
}
