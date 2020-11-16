using System;

namespace Vector3
{
    class Program
    {
        static void Main(string[] args)
        {
            float longueur1;
            float longueur2;
            float distance;
            Vector3 coordonnée1 = new Vector3(2, 1.5f, 4);
            Vector3 coordonnée2 = new Vector3(5, 8, 2.3f);
            Console.WriteLine($"{coordonnée1}, {coordonnée2}");
            coordonnée1 = Vector3.Translate(coordonnée1, 1, 4 , 2);
            coordonnée2 = Vector3.Translate(coordonnée2, 3, 1 , 6);
            Console.WriteLine($"{coordonnée1}, {coordonnée2}");
            longueur1 = Vector3.Longueur(coordonnée1);
            longueur2 = Vector3.Longueur(coordonnée2);
            Console.WriteLine($"{longueur1}, {longueur2}");
            distance = Vector3.Distance(coordonnée1, coordonnée2);
            Console.WriteLine($"{distance}");
        }

        public struct Vector3
        {
            public float xInit;
            public float yInit;
            public float zInit;

            public Vector3(float x, float y, float z)
            {
                xInit = x;
                yInit = y;
                zInit = z;
            }

            public static Vector3 Translate(Vector3 coordonnée, float x2, float y2, float z2)
            {
                coordonnée.xInit += x2;
                coordonnée.yInit += y2;
                coordonnée.zInit += z2;
                return coordonnée;
            }

            public static float Longueur(Vector3 coordonnée)
            {
                float longueur = MathF.Sqrt(coordonnée.xInit*coordonnée.xInit + coordonnée.yInit*coordonnée.yInit + coordonnée.zInit*coordonnée.zInit);
                return longueur;
            }

             public static float Distance(Vector3 coordonnée1, Vector3 coordonnée2)
            {
                float distance = MathF.Sqrt((coordonnée2.xInit - coordonnée1.xInit)*(coordonnée2.xInit - coordonnée1.xInit) + (coordonnée2.yInit - coordonnée1.yInit)*(coordonnée2.yInit - coordonnée1.yInit) + (coordonnée2.zInit - coordonnée1.zInit)*(coordonnée2.zInit - coordonnée1.zInit));
                return distance;
            }

            public override string ToString()
            {
                string toDisplay = $"({xInit}, {yInit}, {zInit})";
                return toDisplay;
            }
        }
    }
}
