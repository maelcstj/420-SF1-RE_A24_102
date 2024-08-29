/*
 * Auteur : Mael Perreault
 * Date : 26 aout 2024
 * Cours 03 - Entrées sorties
 */

using System.Globalization;

namespace Cours03_EntreesSorties
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            int nombreEntier = 2147483647;
            // int 32 bits 
            // 0 (+) 0000000 00000000 00000000 00000000 (0)
            // 1 (-) 1111111 11111111 11111111 11111111 (2^31 - 1)
            // 2^31 - 1 = 2147483648 - 1 = 2147483647

            // uint 32 bits 
            // 00000000 00000000 00000000 00000000 (0)
            // 11111111 11111111 11111111 11111111 (2^32 - 1)
            // 2^32 = 4294967296

            // double 64 bits
            // 0 (+) 0000000 (Exposant) 0000 ... 000 (Nombre a virgule)
            // 1.26346465 E 108

            double nombreVirgule = 10; // 10 -> 1 E 2

            // char 16 bits
            // 00000000 00000000
            // 11111111 11111111 (2^16 - 1)
            // 2^16 - 1 = 65536 - 1 = 65535

            //char caractere = 'A'; // 0 - 255 A-Z a-z 0-9

            //// string 16 bits * # caracteres (char) + 16 bits caractere fins \0
            //string message = "Bonjour!";

            int nombre1 = 9;
            int nombre2 = 5;
            double facteur = nombre1 / nombre2;
            Console.WriteLine(facteur);

            Console.Write("Entrer un nombre : ");
            string entree = Console.ReadLine();
            // int nombreEntre = int.Parse(entree); // '1' '3' '5' \0 => 135
            double nombreEntre = double.Parse(entree, CultureInfo.InvariantCulture); // '1' '.' '3' '5' \0 => 1.35
            int nombreAjoute = 10;
            Console.WriteLine($"\n\n\nNombre entre + {nombreAjoute,-10} \n\n: {nombreEntre + nombreAjoute:0.00000} ");
        }
    }
}
