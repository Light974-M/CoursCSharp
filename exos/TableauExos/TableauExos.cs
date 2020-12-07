using System;

namespace ExosCours
{
    public class TableauExos
    {
        public static void DisplayIntArray(int[] arrayToDisplay)
        {
            string toDisplay = "{";

            for(int i = 0 ; i <= arrayToDisplay.Length ; i++  )
            {
                toDisplay += arrayToDisplay[i];
            }

            toDisplay += "}";

            Console.WriteLine(toDisplay);
        }

        public static void TotalIntArray(int[] arrayToSun)
        {
            for( int i = 0; i < arrayToSun.Length -1; i++)
            {
                arrayToSun[i] += arrayToSun[i++];

            }
        }

        public static int SearchValue(int[] arrayvalue, int valueToSearch)
        {
            for(int i = 0; i<arrayvalue.Length; i++)
            {
                if(valueToSearch == arrayvalue[i])
                {
                    return i;
                }
            }
            
        }
    }
}