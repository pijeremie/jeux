using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuDeNim
{
    internal static class Affichage
    {
        public static Tas[] tabTas = new Tas[4];
        public static void reglesDuJeu()
        {
            Console.WriteLine("\tRègle du jeu");
            Console.WriteLine("\t- on dispose de 4 tas d'allumettes");
            Console.WriteLine("\t- à tour de rôle chaque jour tire un nombre d'allumettes d'un tas");
            Console.WriteLine("\t- celui qui tire la dernière allumette a gagné");
            Console.WriteLine();
        }

        public static void init()
        {
            for (byte i = 0; i < tabTas.Length; i++)
            {     
                tabTas[i] = new Tas((byte)(i + 1), (byte)(2 * i + 1)); 
            } 
        }
        public static void afficher()
        {
            foreach (Tas tas in tabTas)
            {
                Console.WriteLine("\t" + tas);
            }
            Console.WriteLine();
        }
    }
}
