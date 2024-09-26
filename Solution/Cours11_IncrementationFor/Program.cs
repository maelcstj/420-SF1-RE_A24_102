namespace Cours11_IncrementationFor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Operateurs incrementation +1 -1 nombre += 1
            // Pre-incrementation : ++nombre, --nombre
            // Post-incremenation : nombre++, nombre--
            int pre = 0;
            int post = 0;
            Console.WriteLine($"Pre : {++pre}");   // incremente (0 + 1) et utilise (1)
            Console.WriteLine($"Post : {post++}"); // utilise (0) et incremente (0 + 1)

            Console.WriteLine($"Pre apres : {pre}");    // 1
            Console.WriteLine($"Post apres : {post}");  // 1

            // Pas de différence, utilise pas
            ++pre;  // (1 + 1)
            post++; // (1 + 1)

            Console.WriteLine($"Pre apres : {pre}");    // 2
            Console.WriteLine($"Post apres : {post}");  // 2

            // Moyenne : somme / nombre elements
            //int nombreElement = 0;
            //while (true) // lisait des nombre
            //{
            //    bool estNombreValide = true;
            //    if (estNombreValide)
            //        ++nombreElement; // += 1;
            //}

            // Boucle for
            // for(declaration iterateur; condition; incrementation)
            for (int i = 1; i <= 5; i++)
            {
                // Travail
                Console.Write(i);
                Console.Write(" ");
            } // fin variable i

            //// Équivalent boucle while
            {
                int i = 1;
                while (i <= 5)
                {
                    // Travail
                    Console.Write(i);
                    Console.Write(" ");

                    ++i; // incrmenter iterateur (i), sinon boucle infinie!
                }
            } // fin variable i

            // Variables
            // int i = 1, 2, 3, 4, 5
            // ...

            for (int i = 1; i <= 5; i++)
            {
                Console.Write(i);
                Console.Write(" ");
            }

            // Sorties
            // 1 2 3 4 5


            // Comment ecrire des boucles for

            // Identufier Travail répétitif
            Console.WriteLine("Bonjour!");

            // Iterations : 18
            const int NOMBRE_ETUDIANTS = 18;

            // Commencer i = 0 => condition < nombre itérations
            // Commencer i = 1 => condition <= nombre itérations
            for (int i = 0; i < NOMBRE_ETUDIANTS; i++) // 0 1 2 3 4 5 6 ... % 5
            {
                // Ajouter travail ici!
                int numeroEtudiant = 1000 * (i + 1); // i + 1 pour commencer a 1000
                Console.WriteLine($"Bonjour étudiant #{numeroEtudiant}!");

                // Modulo pour un travail à chaque 5 itérations
                // i + 1    si on commence a 0
                // i        si on commence a 1
                if ((i + 1) % 5 == 0)
                {
                    Console.WriteLine("Fin de 5 étudiants");
                }
            }

            // Boucles imbriquées
            // Faire 5 fois le travail
            // Faire 3 fois (5 fois le travail)
            // 1 2 3 4 5
            // 1 2 3 4 5
            // 1 2 3 4 5

            // Étape 1 : écrire un programme laid qui fait le travail 
            //Console.Write("1");
            //Console.Write(" ");
            //Console.Write("2");
            //Console.Write(" ");
            //Console.Write("3");
            //Console.Write(" ");
            //Console.Write("4");
            //Console.Write(" ");
            //Console.Write("5");
            //Console.Write(" ");

            // Identifier le Travail pour un chiffre
            //Console.Write("1");
            //Console.Write(" ");

            // Réduire le travail des chiffres en une boucle for
            for (int i = 1; i <= 5; i++)
            {
                // Travail pour un chiffre
                Console.Write(i);
                Console.Write(" ");
            }

            // Identifier le travail pour toute les lignes
            //// Travail pour une ligne
            //for (int i = 1; i <= 5; i++)
            //{
            //    // Travail
            //    Console.Write(i);
            //    Console.Write(" ");
            //}
            //Console.WriteLine();

            //// Travail pour une ligne
            //for (int i = 1; i <= 5; i++)
            //{
            //    // Travail
            //    Console.Write(i);
            //    Console.Write(" ");
            //}
            //Console.WriteLine();

            //// Travail pour une ligne
            //for (int i = 1; i <= 5; i++)
            //{
            //    // Travail
            //    Console.Write(i);
            //    Console.Write(" ");
            //}
            //Console.WriteLine();

            // Réduire le travail répétitif de chaque ligne avec une 2ème boucle for
            for (int ligne = 0; ligne < 3; ligne++) // 3 fois
            { 
                // Travail d'une ligne!
                for (int nombre = 1; nombre <= 5; nombre++) // 15 = 5 fois x 3
                {
                    // Travail
                    Console.Write(nombre); // ligne 
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
    }
}
