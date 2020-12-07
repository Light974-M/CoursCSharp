using System;

namespace TableauExos
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            Console.WriteLine(rand.Next(0,10));

            int [] tabExo1 = new int[]{4, 6, 8, 2, 12};
            TableauExos.DisplayIntArray(tabExo1);

            
        }
    }
}
