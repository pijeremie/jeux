using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morpion
{
    internal class Ordinateur
    {
        static Random generateur = new Random();
        public static void choisirCaseOrdinateur(EtatCase[,] grille)
        {
            Console.WriteLine("\nAu tour de l'ordi :");
            bool choixKO = true;
            do
            {
                int ligne = generateur.Next(0, 3);
                int colonne = generateur.Next(0, 3);
                Console.WriteLine("  > Il teste la case n°" + (3 * ligne + colonne));
                if (grille[ligne, colonne] == EtatCase.Vide)
                {
                    Console.WriteLine("  > Il choisit la case n°" + (3 * ligne + colonne));
                    grille[ligne, colonne] = EtatCase.Croix;
                    choixKO = false;
                }
            } while (choixKO);
            Grille.afficherGrille(grille);
        }
    }
}
