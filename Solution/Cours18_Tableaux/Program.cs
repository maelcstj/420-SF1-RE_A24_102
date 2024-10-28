/*
 * Auteur : Mael Perreault
 * Date : 28 octobre 2024
 * Cours 18 - Tableaux
 */

namespace Cours18_Tableaux
{
    internal class Program
    {
        private const bool ACTIVER_THEORIE = true;
        private const int MAX_JOUEURS = 5;

        static void Main(string[] args)
        {
            if (ACTIVER_THEORIE)
            {
                // Ancienne façon avec plusieurs variables
                string joueur0 = "Al";
                string joueur1 = "Bob";
                string joueur2 = "Carl";
                string joueur3 = "Dan";

                // Nouvelle façon avec une seule variable (tableau)
                // Déclarer et initialiser des tableaux
                string[] joueurs = new string[MAX_JOUEURS] 
                {
                    "Al",
                    "Bob",
                    "Carl",
                    "Dan",
                    "Earl",
                };

                int[] points = new int[MAX_JOUEURS] 
                {
                    10,
                    20,
                    30,
                    40,
                    50,
                };

                // Index -1 ou taille du tableau causent un crash!
                //joueurs[-1] = "Erreur!";
                //joueurs[MAX_JOUEURS] = "Erreur!";

                // Changer les valeurs à certains index du tableau
                //joueurs[0] = "Al";
                //joueurs[1] = "Bob";
                //joueurs[2] = "Carl";
                //joueurs[3] = "Dan";

                // Itérer le tableau [0, taille du tableau[
                Console.WriteLine("Les joueurs sont : ");
                for (int i = 0; i < MAX_JOUEURS; i++)
                {
                    Console.WriteLine($"{joueurs[i]} : {points[i]}");
                }
            }

            // Exercices
        }
    }
}
