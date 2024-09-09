using System.Globalization;

namespace Cours06_ConstantesModulo
{
    internal class Program
    {
        // Constantes (SNAKE_UPPER_CASE)
        const int NOMBRE_A_AJOUTER = 99; // 10 => 99
        const string MEMBRE_OR = "gold"; // "or" => "gold"
        const int JANVIER = 1;
        const int DECEMBRE = 12;
        const int VALEUR_ADDITION_ENTIER = 100;
        const bool THEORIE_ACTIF = true;

        static void Main(string[] args)
        {
            // Configurer CultureInfo pour tout le programme
            // Important! Faire au debut!
            CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;

            if (THEORIE_ACTIF) // false
            {
                Console.WriteLine("Entrer un nombre entier : ");
                string entreeNombreEntier = Console.ReadLine();
                // int entier = int.Parse(entreeNombreEntier);

                // int entier; // Peut ecrire ici (out)
                // bool estEntierValide = int.TryParse(entreeNombreEntier, out entier);

                bool estEntierValide = int.TryParse(entreeNombreEntier, out int entier);
                if (estEntierValide == true)
                {
                    // +=, -=, *=, /=
                    // nombre = nombre + 10;
                    // nombre += 10;
                    entier += VALEUR_ADDITION_ENTIER;
                    entier -= 50;
                    entier /= 2;

                    Console.WriteLine($"Le nombre + {NOMBRE_A_AJOUTER} est : {entier + NOMBRE_A_AJOUTER}");
                }
                else
                {
                    Console.WriteLine("Le nombre est invalide");
                }

                Console.WriteLine("Entrer un nombre virgule : ");
                string entreeNombreVirgule = Console.ReadLine();
                // double virgule = double.Parse(entreeNombreVirgule, CultureInfo.InvariantCulture);

                // double virgule; // Peut ecrire ici (out)
                // bool estVirguleValide = double.TryParse(entreeNombreVirgule, CultureInfo.InvariantCulture, out virgule);

                // bool estVirguleValide = double.TryParse(entreeNombreVirgule, CultureInfo.InvariantCulture, out double virgule);
                bool estVirguleValide = double.TryParse(entreeNombreVirgule, out double virgule); // Avec CurrentCulture!
                if (estVirguleValide == true)
                {
                    Console.WriteLine($"Le nombre + {NOMBRE_A_AJOUTER} est : {virgule + NOMBRE_A_AJOUTER:0.000}");
                }
                else
                {
                    Console.WriteLine("Le nombre est invalide");
                }

                //THEORIE_ACTIF = true; // erreur, impossible

                // Division
                // 11 / 5 = 2 reste 1
                int quotient = 11 / 5;  // 2
                int reste = 11 % 5;     // 1 (reste)

                // 4 / 2 = 2 reste 0 (pair)
                // 5 / 2 = 2 reste 1 (impair)
                if (entier % 2 == 0) // division par 2, reste 0
                {
                    Console.WriteLine($"Le nombre {entier} est pair");
                }
                else // division par 2, reste 1
                {
                    Console.WriteLine($"Le nombre {entier} est impair");
                }
            }
        }
    }
}
