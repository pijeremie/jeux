using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuDeNim
{
    internal static class Ordinateur
    {
        //l'ordinateur choisit un tas
        public static int choixTas(Tas[] pTabTas, bool[] curseur)
        {
            for (int i = 0; i < curseur.Length; i++)
            {
                if (curseur[i])
                {
                    for (int j = 0; j < pTabTas.Length; j++)
                    {
                        if (pTabTas[j].NombreAllumetteBin[i] == true)
                        {
                            return j;
                        }
                    }
                }
            }
            return 0;
        }

        //convertir en binaire le nombre d'allumettes saisis
        public static bool[] trouverCurseur(Tas[] pTabTas)
        {
            bool[] curseur = new bool[3];
            for (int i = 0; i < 3; i++)
            {
                curseur[i] = (pTabTas[0].NombreAllumetteBin[i] ^ pTabTas[1].NombreAllumetteBin[i]) ^ (pTabTas[2].NombreAllumetteBin[i] ^ pTabTas[3].NombreAllumetteBin[i]);
            }
            return curseur;
        }

        public static void ordiJoue(Tas[] pTabTas, bool[] curseur)
        {
            int numeroTas = choixTas(pTabTas, curseur);
            bool[] tab = pTabTas[numeroTas].NombreAllumetteBin;
            int nombreAllumette = pTabTas[numeroTas].NombreAllumette;
            int nbrAllumettesPrises;
            for (int i = 0; i < curseur.Length; i++)
            {
                if (curseur[i])
                {
                    tab[i] = !tab[i];
                }
            }
            pTabTas[numeroTas].NombreAllumetteBin = tab;
            nbrAllumettesPrises = nombreAllumette - pTabTas[numeroTas].NombreAllumette;
            Console.WriteLine("\tL'ordi prend " + nbrAllumettesPrises + " allumette(s) du Tas " + (numeroTas + 1)); 
        }
    }
}
