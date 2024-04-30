using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuDeNim
{
    internal class Jeux
    {
        public static void nouvellePartie(Tas[] pTabtas)
        {
            Affichage.reglesDuJeu();
            Affichage.init();
            Affichage.afficher();
            int choix;
            do
            {
                Console.Write("\tVoulez-vous commencer une nouvelle partie (oui: tapez 1, non: tapez 0) : ");
            }
            while (!int.TryParse(Console.ReadLine(), out choix) || choix < 0 || choix > 1) ;
            Console.Clear();
            if (choix == 1)
            {
                Console.WriteLine();
                Affichage.afficher();
                bool tour = true;
                while (jeuGagnant(pTabtas))
                {
                    if (tour)
                    {
                        Console.WriteLine("        ~ A votre tour");
                        Joueur.joueurJoue(pTabtas);
                        Console.WriteLine();
                        Affichage.afficher();
                        tour = !tour;
                    }
                    else
                    {
                        Console.WriteLine("        ~ Au tour de l'ordi\n");
                        Ordinateur.ordiJoue(pTabtas, Ordinateur.trouverCurseur(pTabtas));
                        Console.WriteLine();
                        Affichage.afficher();
                        tour = !tour;
                    }
                }
                if (tour)
                {
                    Console.WriteLine("\n\tVous avez perdu !!!");
                }
                else
                {
                    Console.WriteLine("\n\tVous avez gagné !!!");
                }
            }
            else if (choix == 0)
            {
                Environment.Exit(0);
            }
        }

        public static bool jeuGagnant(Tas[] pTabTas)
        {  
            for (int i = 0; i < pTabTas.Length; i++)
            {
                if (pTabTas[i].NombreAllumette != 0)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
