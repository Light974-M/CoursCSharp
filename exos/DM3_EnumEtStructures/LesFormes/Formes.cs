using System;

namespace Formes
{
    public class FormesInput
    {
        enum TypeForme
        {
        TriangleRectangle,
        TriangleIsocele,
        Diamant,
        FauxCarre,
        VraiCarre,
        DiamondSquare,
        }

        public struct Forme
        {
            private TypeForme typeForm;
            private int taille;

            private Forme(TypeForme typeFormInit, int tailleInit)
            {
                typeForm = typeFormInit;
                taille = tailleInit;
            }

            public override string ToString()
            {   
                
                string toDisplay = "";
                return toDisplay;
            }
        }
    }
}

