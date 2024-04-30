using System.Runtime.CompilerServices;

namespace Morpion
{
    internal class Program
    {
        public static EtatCase[,]? grille; 

        static void Main(string[] args)
        {
            grille = new EtatCase[3, 3];
            int compteur = 9;
            bool gagner = false;

            Console.WriteLine("JEU DU MORPION");

            Console.WriteLine("\nL'ordinateur prend les 'X'");
            Console.WriteLine(" => vous prenez les 'O'");
            
            Grille.afficherGrille(grille);

            while (compteur > 0 && !gagner)
            {
                if (compteur % 2 == 1)
                {
                    Ordinateur.choisirCaseOrdinateur(grille);
                    gagner = Resultat.jeuGagnant(EtatCase.Croix, grille);
                }
                else
                {
                    Joueur.choisirCaseUtilisateur(grille);
                    gagner = Resultat.jeuGagnant(EtatCase.Rond, grille);
                }
                compteur--;
            }
            switch (Resultat.leGagnant(grille))
            {
                case 1:
                    Console.WriteLine("Vous avez perdu !!");
                    break;
                case -1:
                    Console.WriteLine("Vous avez gagné !!");
                    break;
                default:
                    Console.WriteLine("Match nul !!");
                    break;
            }
        }
    }
}

