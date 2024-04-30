using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morpion
{
    internal class Joueur
    {
        public static void choisirCaseUtilisateur(EtatCase[,] grille)
        {
            Console.WriteLine("\nA vous de jouer :");
            bool choixKO = true;
            do
            {
                int choix;
                string choixNombre;
                do
                {
                    Console.Write("  > Je teste la case n°"); 
                    choixNombre = Console.ReadLine();
                }
                while (!int.TryParse(choixNombre, out choix) || choix < 0 || choix > 8);
                int ligne = choix / 3;
                int colonne = choix % 3;
                if (grille[ligne, colonne] == EtatCase.Vide)
                {
                    Console.WriteLine("  > Je choisis la case n°" + (3 * ligne + colonne));
                    grille[ligne, colonne] = EtatCase.Rond;
                    choixKO = false;
                }
            }
            while (choixKO);
            Grille.afficherGrille(grille);
        }
    }
}
