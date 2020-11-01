using System;

namespace StateLife
{
    class Program
    {
        static void Main(string[] args)
        {
            int life = 100;
            bool Invincible = true;
            int damage = 50;
            
            if(!Invincible & life >= 0)
            {
                life -= damage;
            }
            Console.WriteLine("vie :" + life);


        }
    }
}
