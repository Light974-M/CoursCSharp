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

            float PrixProduit1TTC20 = PrixProduit1HT * (1+(TVA/100));
            float PrixProduit2TTC20 = PrixProduit2HT * (1+(TVA/100));
            float PrixProds1TTC20 = PrixProduit1TTC20 * QuantitéProd1;
            float PrixProds2TTC20 = PrixProduit2TTC20 * QuantitéProd2;

            float PrixProduit1TTC5 = PrixProduit1HT * (1+(TVABasic/100));
            float PrixProduit2TTC5 = PrixProduit2HT * (1+(TVABasic/100));
            float PrixProds1TTC5 = PrixProduit1TTC5 * QuantitéProd1;
            float PrixProds2TTC5 = PrixProduit2TTC5 * QuantitéProd2;

            float PrixProdsHT = (PrixProduit1HT * QuantitéProd1) + (PrixProduit2HT * QuantitéProd2);
            float PrixProdsTTC20 = PrixProds1TTC20 + PrixProds2TTC20;
            float PrixProdsTTC5 = PrixProds1TTC5 + PrixProds2TTC5;

            float PrixProdsTTC = PrixProdsHT * (1+((TVA+TVABasic)/100));

            Console.WriteLine("les produits 1 valent : " + PrixProds1TTC20 + " avec une TVA de 20%. ");
            Console.WriteLine("les produits 2 valent : " + PrixProds2TTC20 + " avec une TVA de 20%. ");
            Console.WriteLine("les produits 1 valent : " + PrixProds1TTC5 + " avec une TVA de 5%. ");
            Console.WriteLine("les produits 2 valent : " + PrixProds2TTC5 + " avec une TVA de 5%. ");
            Console.WriteLine("le prix total HT : " + PrixProdsHT);
            Console.WriteLine("le prix total TTC a 20% de TVA : " + PrixProdsTTC20);
            Console.WriteLine("le prix total TTC a 5% de TVA : " + PrixProdsTTC5);
            Console.WriteLine("le prix total avec toutes les TVA : " + PrixProdsTTC);
        }
    }
}
