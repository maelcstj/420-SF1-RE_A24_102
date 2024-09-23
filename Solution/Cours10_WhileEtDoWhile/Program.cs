namespace Cours10_WhileEtDoWhile
{
    internal class Program
    {
        const bool ACTIVER_THEORIE = true;

        static void Main(string[] args)
        {
            if (ACTIVER_THEORIE)
            {
                string chaine = "";

                string lettre = ""; // Initialiser
                while (lettre != "-1") //Effectuée 0+ fois
                {
                    Console.Write("Entrer lettre : ");
                    lettre = Console.ReadLine();

                    if (lettre != "-1")
                    {
                        chaine += lettre;
                        chaine += lettre;
                    }

                }

                Console.WriteLine($"La chaine est : {chaine}");

                chaine = "";
                string lettreDoWhile; // Pas besoin initialiser 
                do // Effectué 1+ fois
                {
                    Console.Write("Entrer lettre : ");
                    lettreDoWhile = Console.ReadLine();

                    if (lettreDoWhile != "-1")
                    {
                        chaine += lettreDoWhile;
                        chaine += lettreDoWhile;
                    }
                } while (lettreDoWhile != "-1");

                Console.WriteLine($"La chaine est : {chaine}");
            }

            // Exercices ...
        }
    }
}
