/*
 * Auteur : Mael Perreault
 * Date : 5 septembre 2024
 * Cours 05 - Scope et Switch
 */

namespace Cours05_ScopeSwitch
{
    internal class Program
    {
        static void Main(string[] args)
        { // Scope 1 - debut
            Console.WriteLine("Hello, World!");

            int a = 10;
            int b = 20;

            Console.WriteLine(a);
            Console.WriteLine(b);

            { // Scope 2 - debut
                //int a = 15; // a existe deja dans Scope 1
                int c = 30;
                Console.WriteLine(a); // 10 -> Scope 1
                Console.WriteLine(c); // 30 -> Scope 2
            } // Scope 2 - fin

            { // Scope 3 - debut
              //int a = 15; // a existe deja dans Scope 1
                int c = 40;
                Console.WriteLine(a); // 10 -> Scope 1
                Console.WriteLine(c); // 40 -> Scope 3          
            } // Scope 3 - fin

            // Théorie
            {
                Console.Write("Nombre : ");
                string entreeNombre = Console.ReadLine();
                int nombre = int.Parse(entreeNombre);

                int valeur = 0;

                if (nombre > 100)
                {
                    Console.WriteLine("Nombre positif plus 100");
                    valeur = 20 * 10 * nombre;
                }
                else if (nombre > 0)
                {
                    Console.WriteLine("Nombre positif");
                    valeur = 5 * nombre;
                }
                else if (nombre < -100)
                {
                    Console.WriteLine("Nombre negatif moins que -100");
                }
                else if (nombre < 0)
                {
                    Console.WriteLine("Nombre negatif");
                }
                else
                {
                    Console.WriteLine("Nombre zero");
                }

                Console.WriteLine($"Le total est : {valeur}");

                Console.Write("Membre : ");
                string membre = Console.ReadLine();

                if (membre == "or")
                {

                }
                else if (membre == "argent")
                {

                }
                //else if (membre == "bronze")
                //{

                //}
                else // invalide, bronze
                {

                }

                switch (membre)
                {
                    case "o":
                    case "R":
                    case "or":
                    case "OR":
                        {
                            int pointsBonis = 10;
                            Console.WriteLine("Points bonis : " + pointsBonis * 100);
                        }
                        break;
                    case "a":
                    case "A":
                    case "argent":
                    case "ARGENT":
                        // case "bronze": // erreur, defini 2 fois
                        {
                            int pointsBonis = 8;
                            Console.WriteLine("Points bonis : " + pointsBonis * 8);
                        }
                        break;
                    case "b":
                    case "B":
                    case "bronze":
                    case "BRONZE":
                        Console.WriteLine("Pas de points bonis");
                        break;
                    default:
                        Console.WriteLine("Type de membre invalide");
                        break;
                }

                switch (nombre) // int
                {
                    case 1: break;
                    //case '1':  break; // compare int et char
                    //case "1":  break; // compare int et string
                    case 2: break;
                    case 3: break;
                    default: break;
                }

                switch (entreeNombre) // string
                {
                    case "1": break;
                    //case 1:  break; // compare string et int
                    //case '1':  break; // compare string et char
                    case "2": break;
                    case "3": break;
                    default: break;
                }
            }

        } // Scope 1 - fin
    }
}
