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

                string lettre = ""; // Initialiser pour condition du while soit true
                while (lettre != "-1") //Effectué 0+ fois
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

            // Exercice 1
            // TODO: lire une entrée
            // TODO: quitter si entrée est Q / q

        }
    }
}
