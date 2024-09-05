/*
 * Auteur : Mael Perreault
 * Date : 29 aout 2024
 * Cours 04 - Booléens et if/else
 */

namespace Cours04_BooleensIfElse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            // Opérateurs comparaison
            // >, <, >=, <=, ==, !=
            // true  (valeur 1 ou autres valeur : -1, -100)
            // false (valeur 0)
            bool estVrai = 5 > 0; // true (tout le reste)
            bool estFaux = 5 < 0; // false (0)

            Console.WriteLine(estVrai);
            Console.WriteLine(estFaux);

            Console.WriteLine("Comparaison types différents");
            // int == int
            Console.WriteLine(5 == 5);
            // int == double
            Console.WriteLine(5 == 5.0);
            // int == char
            Console.WriteLine(5 == '5'); // 5 == 53 FALSE!
            // int == string
            //Console.WriteLine(5 == "5"); // 5 == '5' '\0'
            Console.WriteLine(5.ToString() == "5"); // 5 => '5' '\0' == '5' '\0'
            // string == char
            //Console.WriteLine("5" == '5'); // '5' '\0' == '5'
            Console.WriteLine("5" == '5'.ToString()); // '5' => '5' '\0' == '5' '\0'

            Console.WriteLine("Comparaison chaine de caracteres");
            Console.WriteLine("bonjour" == "bonjour"); // true
            Console.WriteLine("bonjour" == "Bonjour"); // false
            Console.WriteLine("bonjour" == "bonjour "); // false
            Console.WriteLine("bonjour" == " bonjour"); // false
            Console.WriteLine("bonjour" == "bon jour"); // false
            Console.WriteLine("bonjour" == "bonjou"); // false

            // Opérateurs logiques
            // et (and) : && = 2 conditions doivent etre true
            // ou (or) : || = au moins une des 2 condition doit etre true
            // non (not) : !( condition ) = inverse true => false ou false => true

            Console.Write("Nombre : ");
            string entree = Console.ReadLine();
            int nombre = int.Parse(entree);
            bool estEntre10Et20 = nombre > 10 && nombre < 20;
            bool estEntre10Ou20 = nombre > 10 || nombre < 20;
            bool nestPasEntre10Et20 = !(nombre > 10 || nombre < 20);
            // bool estEntre10Et20 = false || true;
            // bool estEntre10Et20 = true;
            Console.WriteLine(estEntre10Et20);
            Console.WriteLine(estEntre10Ou20);
            Console.WriteLine(nestPasEntre10Et20);

            if (nombre > 10 && nombre < 20)
            {
                // travail a faire si true
                Console.WriteLine("Le nombre est entre 10 et 20");
            }
            else
            {
                // travail a faire si false
                Console.WriteLine("Le nombre n'est pas entre 10 et 20");
            }
            // fin aprres 1 des 2 travaux

            Console.WriteLine("Erreur utilisation de = au lieu de ==");
            //int nombreABriser = 10; // nombreABriser = 10 => 10
            //if (nombreABriser = 20) // nombreABriser = 20 => 20 (true)
            //{
                
            //}
            //else
            //{
                
            //}

        }
    }
}
