using System;

namespace ExoCours
{
    public struct Point
    {
        public int x;
        public int y;
        public string name;

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
            name = "omega";
        }

        public Point(int x, int y, string name)
        {
            this.x = x;
            this.y = y;
            this.name = name;
        }

        public override string ToString()
        {
            return $"le point {name} a comme coordonnées ({x}, {y})";
        }

        public float longueur()
        {
            return Math.Sqrt(x*x + y*y);
            
        }
    }
}