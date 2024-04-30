using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morpion
{
    internal class Grille
    {
        public static void afficherGrille(EtatCase[,] grille)
        {
            String dessinGrille = "\n";
            dessinGrille += " ____________ \n";
            for (int i = 0; i < 3; i++)
            {
                dessinGrille += " | ";
                for (int j = 0; j < 3; j++)
                {
                    switch (grille[i, j])
                    {
                        case EtatCase.Croix:
                            dessinGrille += 'X';
                            break;
                        case EtatCase.Rond:
                            dessinGrille += 'O';
                            break;
                        default:
                            dessinGrille += i * 3 + j;
                            break;
                    }
                    dessinGrille += " | ";
                }
                dessinGrille += "\n ____________ \n";
            }
            Console.WriteLine(dessinGrille);
        }
    }
}
