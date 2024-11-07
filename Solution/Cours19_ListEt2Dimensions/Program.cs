/*
 * Auteur : Mael Perreault
 * Date : 31 octobre 2024
 * Cours 19 - List et tableaux à 2 dimensions
 */

namespace Cours19_ListEt2Dimensions
{
    internal class Program
    {
        private const bool ACTIVER_THEORIE = true;
        private const int MAX_JOUEURS = 4;
        private const int MAX_MANCHES = 10;

        static void Main(string[] args)
        {
            if (ACTIVER_THEORIE)
            {
                // List a une taille infinie
                List<int> entiers = new List<int>()        // int[] entiers = new int[10];
                {
                    10,
                    20,
                    30,
                };

                List<double> doubles = new List<double>()  // double[] doubles = new double[10];
                {
                    1.234,
                    2.456,
                    3.789,
                };

                List<string> chaines = new List<string>()  // string[] chaines = new string[10];
                {
                    "allo",
                    "bonjour",
                    "ciao",
                };

                // Opérations supplémentaires List
                // Add : ajoute la valeur à la fin de la liste
                entiers.Add(40);
                doubles.Add(4.587);
                chaines.Add("pogo");

                // Insert : insere la valeur à un index de la liste
                entiers.Insert(0, 50);
                doubles.Insert(0, 5.5145);
                chaines.Insert(0, "poutine");

                // Erreur, on dépasse le tableau
                //entiers.Insert(50, 100);
                //doubles.Insert(50, 10.5145);
                //chaines.Insert(50, "oh nooooo");

                // Ok pour la taille du tableau, donc équivalent a un Add
                entiers.Insert(entiers.Count, 100);
                doubles.Insert(doubles.Count, 10.5145);
                chaines.Insert(chaines.Count, "oh nooooo");

                // Remove : trouve la premiere valeur equivalent et la supprime
                // Ne crash pas si la valeur n'est pas trouvée, fait rien
                entiers.Remove(10); // supprimer la valeur
                entiers.Remove(10); // fait rien
                entiers.Remove(10); // fait rien

                doubles.Remove(1.234);
                doubles.Remove(1.234);
                doubles.Remove(1.234);

                chaines.Remove("allo");
                chaines.Remove("allo");
                chaines.Remove("allo");

                // RemoveAt : supprime l'element à l'index
                entiers.RemoveAt(2);
                doubles.RemoveAt(2);
                chaines.RemoveAt(2);

                // Erreur, index doit exister
                //entiers.RemoveAt(50);

                // Clear : supprime tous les elements
                //entiers.Clear();
                //doubles.Clear();
                //chaines.Clear();

                // Itération de la liste (for)
                for (int i = 0; i < entiers.Count; i++)
                {
                    Console.WriteLine($"{chaines[i]} : {doubles[i]} - {entiers[i]}");
                }

                // Tableaux à 2 dimensions
                // Tableau multidimensionnel (2D array)
                // 4 joueurs, 10 manches = partie de quille
                // Tableau de taille fixe, initialisé valeurs par défaut (ex. 0, "")
                int[,] pointages = new int[MAX_JOUEURS, MAX_MANCHES]
                {
                    { 10, 10, 7, 0, 0, 0, 0, 0, 0, 0 },
                    { 5, 10, 3, 0, 0, 0, 0, 0, 0, 0 },
                    { 6, 5, 10, 0, 0, 0, 0, 0, 0, 0 },
                    { 2, 3, 10, 0, 0, 0, 0, 0, 0, 0 },
                };

                pointages[0, 3] = 6;
                pointages[1, 3] = 4;
                pointages[2, 3] = 7;
                pointages[3, 3] = 10;

                pointages[0, 4] = 6;

                pointages[0, 7] = 10;

                for (int manche = 0; manche < MAX_MANCHES; manche++)
                {
                    int numeroManche = manche + 1;
                    Console.WriteLine($"Manche {numeroManche}");

                    for (int joueur = 0; joueur < MAX_JOUEURS; joueur++)
                    {
                        int numeroJoueur = joueur + 1;
                        Console.Write($"Joueur {numeroJoueur} : ");

                        int pointage;
                        bool estPointageValide;
                        do
                        {
                            string entree = Console.ReadLine();
                            estPointageValide = int.TryParse(entree, out pointage);
                        } while (!estPointageValide);

                        pointages[joueur, manche] = pointage;
                    }
                }

                List<int> totalJoueurs = new List<int>();

                for (int joueur = 0; joueur < MAX_JOUEURS; joueur++)
                {
                    int numeroJoueur = joueur + 1;
                    Console.Write($"Joueur {numeroJoueur} : ");

                    int total = 0;

                    for (int manche = 0; manche < MAX_MANCHES; manche++)
                    {
                        int pointage = pointages[joueur, manche];
                        Console.Write($"{pointage} ");

                        total += pointage;
                    }

                    totalJoueurs.Add(total);

                    Console.WriteLine();
                }

                for (int i = 0; i < totalJoueurs.Count; i++)
                {
                    Console.WriteLine($"Total joueur {i+1} : {totalJoueurs[i]}");
                }
            }
        }
    }
}
