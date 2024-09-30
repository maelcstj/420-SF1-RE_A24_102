using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Cours12_ExercicesBoucles
{
    internal class Program
    {
        const bool ACTIVER_THEORIE = true;

        static void Main(string[] args)
        {
            if (ACTIVER_THEORIE)
            {
                // Demander a utilisateur un nombre tant que le nombre est pas valide
                int nombre = 0;
                bool estNombreValide = false;
                while (estNombreValide == false)
                {
                    Console.Write("Entrer un nombre : ");
                    string entreeNombre = Console.ReadLine();
                    estNombreValide = int.TryParse(entreeNombre, out nombre);

                    if (estNombreValide == false)
                        Console.WriteLine("Erreur : nombre invalide !");
                }

                // Une fois le nombre valide, écrire Le nombre est : ###
                Console.WriteLine($"Le nombre est : {nombre}");
            }
        }
    }
}
