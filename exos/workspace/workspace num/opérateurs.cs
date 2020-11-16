using System;

namespace Cours
{
    public class Operateurs
    {
        enum LesOperateurs
        {
            Plus,
            Moins,
            Multiplier,
            Diviser,
            Modulo,
        }

        static bool Calculate(LesOperateurs operation, int valx , int valy)
        {
           switch (operation)
            {
                case LesOperateurs.Plus:
                    return valx + valy;
            }
        }
    }
    
}