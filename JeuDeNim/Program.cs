namespace JeuDeNim
{
    internal class Program
    { 
        static void Main(string[] args)
        {   
            /*
            Tas tas1 = new Tas(1, 5); 
            Console.WriteLine("conversion en byte: " + tas1.NombreAllumette);
            Console.Write("conversion en binaire: ");
            foreach (bool bin in tas1.NombreAllumetteBin)
            {
                Console.Write(bin); 
            }
            */
            Console.WriteLine("\n");
            Jeux.nouvellePartie(Affichage.tabTas);
        }
    }
}