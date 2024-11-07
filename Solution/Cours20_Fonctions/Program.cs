/*
 * Auteur : Mael Perreault
 * Date : 7 novembre 2024
 * Cours 20 - Fonctions
 */




namespace Cours20_Fonctions
{
    internal class Program
    {
        // Déclaration d'une fonction
        // <accesseurs> <type de retour> <nom de la fonction>(<parametres>)
        // Accesseurs : public, private, static*** (imposé par C# pour l'instant)
        // Type de retour : ce qui est retourné par l'instruction return
        //    - void : retourne rien
        //    - int, double, string, bool, int[], List<int>
        // Nom fonction : PascalCase sans accent
        //    - Verbe action + complément
        //    - Ex. CreerListePointages, AfficherPointages, CalculerSomme, ValiderProduit, LirePointage
        //      - Exception fonction retourne bool. EstNumerique, EstNombrePremier
        //    - Mauvais ex. Calculer, Afficher, Nombre, A, B, C
        static void Main(string[] args)
        {
            Theorie();

            Exercice01();
        }

        private static void Theorie()
        {
            Console.WriteLine("Début Main");

            AfficherAdditions(); // arreter exécution jusqu'à la fin de la fonction

            // Attention, les éléments qui utilisent new pointent tous vers le même objet en mémoire
            // Passer ces éléments en paramètre nous permettent de modifier l'objet original
            List<int> entiers = new List<int>() { 10, 20, 30 };

            AjouterListe(entiers, 40);

            // Valeur 40 est présente dans la liste originale
            Console.Write("List contient : ");
            for (int i = 0; i < entiers.Count; i++)
            {
                Console.Write($"{entiers[i]} ");
            }
            Console.WriteLine();

            // Pour modifier les types de base (int, double, string) de la même façon
            // Il faut passer l'addresse de la variable avec les mots clés : ref ou out
            int entierAModifier1 = 20;
            AjouterValeur(ref entierAModifier1, out int entierAModifier2, 100);
            Console.WriteLine($"Entier ref 1 : {entierAModifier1}");
            Console.WriteLine($"Entier ref 2 : {entierAModifier2}");

            Console.WriteLine("Fin Main");
        }

        // ref : recevoir adresse mémoire des variables dans la fonction original
        // out : permet de définir la variable lorsqu'on appelle la fonction
        // Modifier les valeur dans la fonction ici, modifie les valeurs dans la fonction originale
        private static void AjouterValeur(ref int entierAModifier1, out int entierAModifier2, int valeurAjout)
        {
            entierAModifier1 += valeurAjout;
            entierAModifier2 = valeurAjout;
        }

        private static void AjouterListe(List<int> entiers, int valeurAjout)
        {
            entiers.Add(valeurAjout);
        }

        private static void Exercice01()
        {
            // Tests pour les fonctions de l'exercice 01
            //LireEntier()
        }

        private static void AfficherAdditions()
        {
            Console.WriteLine("Début AfficherAdditions");

            int entier1 = 10; // débute avec 10, ??? => modifie la valeur de l'entier dans fonction
            int entier2 = 5;

            int somme = entier1 + entier2;
            int sommeFonction = AdditionnerEntiers(entier1, entier2);

            Console.WriteLine($"Addition sans fonction : {somme}");
            Console.WriteLine($"Addition avec fonction : {sommeFonction}");

            Console.WriteLine($"Entier1 : {entier1}"); // 10? 15?
            Console.WriteLine($"Entier2 : {entier2}");

            Console.WriteLine("Fin AfficherAdditions");
        }

        static int AdditionnerEntiers(int entier1, int entier2)
        {
            Console.WriteLine("Début AdditionnerEntiers");

            // entier1 = 10 + 5 = 15
            entier1 = entier1 + entier2;

            // Erreur, doit retourner le type de retour (int)
            //if (somme > 10)
            //    return "Plus grand";

            Console.WriteLine("Fin AdditionnerEntiers");

            // 15
            return entier1;
        }
    }
}
