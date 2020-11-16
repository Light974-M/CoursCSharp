using System;

namespace exo_2_enum
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
            Automn,
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
            Console.WriteLine("what month is it ?");
            string month = Console.ReadLine();
            month = month.ToLower();
            
        }

        static void MonthTransform(Month month)
        {
            switch(month)
            {
                case Month.January:
                    month = Month.January;
                    Console.WriteLine(month);
                    break;
                case Month.February:
                    month = Month.February;
                    Console.WriteLine(month);
                    break;
                case Month.March:
                    month = Month.March;
                    Console.WriteLine(month);
                    break;
                case Month.April:
                    month = Month.April;
                    Console.WriteLine(month);
                    break;
                case Month.May :
                    month = Month.May;
                    Console.WriteLine(month);
                    break;
                case Month.June:
                    month = Month.June;
                    Console.WriteLine(month);
                    break;
                case Month.July:
                    month = Month.July;
                    Console.WriteLine(month);
                    break;
                case Month.August:
                    month = Month.August;
                    Console.WriteLine(month);
                    break;
                case Month.September:
                    month = Month.September;
                    Console.WriteLine(month);
                    break;
                case Month.October:
                    month = Month.October;
                    Console.WriteLine(month);
                    break;
                case Month.November:
                    month = Month.December;
                    Console.WriteLine(month);
                    break;
                case Month.December:
                    month = Month.December;
                    Console.WriteLine(month);
                    break;
            }
        }

        static void SeasonTransform(Season month)
        {
            switch(month)
            {
                case Season.Automn:
                    month = Season.Automn;
                    Console.WriteLine(month);
                case Season.Winter:
                    month = Season.Winter;
                    Console.WriteLine(month);
                case Season.Print:
                    month = Season.Print;
                    Console.WriteLine(month);
                case Season.Spring:
                    month = Season.Spring;
                    Console.WriteLine(month);
            }
        }

        static void ColorTransform(Color month)
        {
            switch(month)
            {
                case Color.Green:
                    month = Season.Automn;
                    Console.WriteLine(month);
            }
        }
    }
}
