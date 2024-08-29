/*
 * Auteur : Mael Perreault
 * Date : 22 aout 2024
 * Cours 02 - Git et la syntaxe de base
 */

namespace Cours02_GitSyntaxe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Mon nom est : Mael!");

            int x = 0;

            int resultatEntier = 10 + 20; // int : nombre entier
            resultatEntier = resultatEntier + 100;
            resultatEntier = resultatEntier * 10;
            resultatEntier = resultatEntier / 3;

            double resultatVirgule = 10.123 + 20.234; //double : nombre a virgule
            char unCaractere = '1';
            string chaineDeCaractere = "Allo!";

            Console.WriteLine(resultatEntier);
            Console.WriteLine(resultatVirgule);
            Console.WriteLine(unCaractere);
            Console.WriteLine("Ma chaine est : " + chaineDeCaractere);

            // Exercice 1
            // Calculer aire et permitre d'un triangle
            // Programmer ici
        }
    }
}
