using System;

namespace TableauExosSuite
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=================================exo 6 prébis====================================");
            int[] tabValeur = new int[] { 1, 7, 12, 20, 4};
            ExosTableaux.DisplayIntArray(tabValeur);

            int[] tabAdd = ExosTableaux.InsertValueInArray(tabValeur, 9, 3);
            ExosTableaux.DisplayIntArray(tabAdd);

            tabAdd = ExosTableaux.InsertValueInArray(tabValeur, 45, 5);
            Exostableaux.DisplayIntArray(tabAdd);

            Console.WriteLine("===========================exo 6====================================================");

        }
    }
}
