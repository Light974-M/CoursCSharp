using System;

namespace CalculeTVA
{
    class Program
    {
        static void Main(string[] args)
        {
            float TVA = 20.0f;
            float TVABasic = 5.0f;

            float PrixProduit1HT = 19.64f;
            int QuantitéProd1 = 15;
            float PrixProduit2HT = 254.50f;
            int QuantitéProd2 = 4;

            float PrixProduit1TT20 = PrixProduit1HT * (1+(TVA/100));
            float PrixProduit2TT20 = PrixProduit2HT * (1+(TVA/100));
            float PrixProds1TT20 = PrixProduit1TT20 * QuantitéProd1;
            float PrixProds2TT20 = PrixProduit2TT20 * QuantitéProd2;

            float PrixProduit1TT5 = PrixProduit1HT * (1+(TVABasic/100));
            float PrixProduit2TT5 = PrixProduit2HT * (1+(TVABasic/100));
            float PrixProds1TT5 = PrixProduit1TT5 * QuantitéProd1;
            float PrixProds2TT5 = PrixProduit2TT5 * QuantitéProd2;

            float PrixProdsHT = (PrixProduit1HT * QuantitéProd1) + (PrixProduit2HT * QuantitéProd2);
            float PrixProdsTT20 = PrixProds1TT20 + PrixProds2TT20;
            float PrixProdsTT5 = PrixProds1TT5 + PrixProds2TT5;

            float PrixProdsTT = PrixProdsHT * (1+((TVA+TVABasic)/100));

            Console.WriteLine("les produits 1 valent : " + PrixProds1TT20 + " avec une TVA de 20%. ");
            Console.WriteLine("les produits 2 valent : " + PrixProds2TT20 + " avec une TVA de 20%. ");
            Console.WriteLine("les produits 1 valent : " + PrixProds1TT5 + " avec une TVA de 5%. ");
            Console.WriteLine("les produits 2 valent : " + PrixProds2TT5 + " avec une TVA de 5%. ");
            Console.WriteLine("le prix total HT : " + PrixProdsHT);
            Console.WriteLine("le prix total TT a 20% de TVA : " + PrixProdsTT20);
            Console.WriteLine("le prix total TT a 5% de TVA : " + PrixProdsTT5);
            Console.WriteLine("le prix total avec toutes les TVA : " + PrixProdsTT);
        }
    }
}
