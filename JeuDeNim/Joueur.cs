using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuDeNim
{
    internal static class Joueur
    {
        public static void joueurJoue(Tas[] pTabTas)
        { 
            int numeroTas = choixTas(pTabTas);
            int nombreAllumette = nombreAllumettes(numeroTas, pTabTas); 
            pTabTas[numeroTas].NombreAllumette -= (byte)nombreAllumette;

        }

        //le joueur choisit un tas
        public static int choixTas(Tas[] pTabTas)
        {
            Console.WriteLine();
            int pNumeroTas;
            do
            {
                Console.Write("\t > Choisir un tas entre 1 et " + pTabTas.Length + ": ");
            }
            while (!int.TryParse(Console.ReadLine(), out pNumeroTas) || pNumeroTas < 1 || pNumeroTas > pTabTas.Length || pTabTas[pNumeroTas-1].NombreAllumette == 0);
            return pNumeroTas - 1;    
        }

        //le joueur choisit un nombre d'allumettes à retirer dans le tas
        public static int nombreAllumettes(int pNumeroTas, Tas[] pTabTas)
        {   
            int pNombreAllumette;      
            do
            {
                Console.Write("\t > Choisir un nombre d'allumette(s) à retirer supérieur à 0 et inférieur/égal à " + pTabTas[pNumeroTas].NombreAllumette + ": ");
            }
            while (!int.TryParse(Console.ReadLine(), out pNombreAllumette) || pNombreAllumette < 1 || pNombreAllumette > pTabTas[pNumeroTas].NombreAllumette);
            Console.WriteLine("\n\tJe prends " + pNombreAllumette + " allumette(s) du Tas " + (pNumeroTas+1));   
            return pNombreAllumette;
        }  
    }
}
