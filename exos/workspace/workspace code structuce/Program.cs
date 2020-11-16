using System;

namespace workspace_code_structuce
{
    class Program
    {
        static void Main(string[] args)
        {
            NomStructure varStructure = new NomStructure();
            Console.WriteLine("appel exterieur de al propriété" + varStructure.prop1);

            varStructure.FonctionPublic();

            NomStructure varStructure2 = new NomStructure(1, 10.5f, true);

            varStructure2.prop2 = 10;

            varStructure2.FonctionPublic();

            NomStructure.FonctionStaticPublic();
        }

        struct NomStructure
        {
            private int prop1;
            private float prop2;
            private bool prop3;


            public static int propStatic;
            public NomStructure(int initProp1,float initProp2, bool initProp3)
            {
                prop1 = initProp1;
                prop2 = initProp2;
                prop3 = true;
            }

            private void FonctionPrivate()
            {

            }

            public void FonctionPublic()
            {
                FonctionPrivate();
                Console.WriteLine($"{prop1}, {prop2}, {prop3}");
            }

            public static void FonctionStaticPublic()
            {

            }


        }
    }
}
