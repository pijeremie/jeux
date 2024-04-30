using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morpion
{
    internal class Resultat
    {
        public static bool jeuGagnant(EtatCase etatCase, EtatCase[,] grille)
        {
            for (int i = 0; i < 3; i++)
            {
                if (grille[i, 0] == etatCase && grille[i, 1] == etatCase && grille[i, 2] == etatCase)
                {
                    return true;
                }
            }
            for (int j = 0; j < 3; j++)
            {
                if (grille[0, j] == etatCase && grille[1, j] == etatCase && grille[2, j] == etatCase)
                {
                    return true;
                }
            }
            if (grille[0, 0] == etatCase && grille[1, 1] == etatCase && grille[2, 2] == etatCase)
            {
                return true;
            }
            else if (grille[0, 2] == etatCase && grille[1, 1] == etatCase && grille[2, 0] == etatCase)
            {
                return true;
            }
            return false;
        }

        public static int leGagnant(EtatCase[,] grille)
        {
            if (jeuGagnant(EtatCase.Croix, grille))
            {
                return 1;
            }
            else if (jeuGagnant(EtatCase.Rond, grille))
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }
}
