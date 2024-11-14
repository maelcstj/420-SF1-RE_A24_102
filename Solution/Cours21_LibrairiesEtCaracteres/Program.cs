using System.Linq;

namespace Cours21_LibrairiesEtCaracteres
{
    internal class Program
    {

        static void Main(string[] args)
        {
            ExecuterTheorie();
            ExecuterExercice01();
        }

        private static void ExecuterTheorie()
        {
            /*****************************************
             * Librairie Math
             ******************************************/
            // La librairie Math contient des opérations de base de mathématiques

            // --- Constantes --- 
            // pi = 3.1415926535897931
            double pi = Math.PI;
            double calculPi = Math.PI / 4;

            // e = 2.7182818284590451
            double e = Math.E;
            double calculE = Math.E * 2;

            // --- Calculs utilitaires ---
            // double valeurAbsolue = Math.Abs(nombre);
            double valeurAbsolue = Math.Abs(-10); // -10 => 10

            double nombreUtilisateur = -100;
            double valeurAbsolueUtilisateur = Math.Abs(nombreUtilisateur);

            // double min = Math.Min(nombre1, nombre2);
            double min = Math.Min(16, -2); // -2

            // double max = Math.Max(nombre1, nombre2);
            double max = Math.Max(16, -2); // 16

            // double nombreEntreMinMax = Math.Clamp(nombre, min, max); // [min, max]
            double nombreEntreMinMax1 = Math.Clamp(158, 0, 100);        // [0, 100] => 100
            double nombreEntreMinMax2 = Math.Clamp(-154, 0, 100);       // [0, 100] => 0
            double nombreEntreMinMax3 = Math.Clamp(25, 0, 100);         // [0, 100] => 25

            // int entierInferieur = (int)Math.Floor(nombreVirgule);
            double doubleInferieur = Math.Floor(5.999999999);       // 5
            int entierInferieur1 = (int)Math.Floor(5.999999999);    // 5
            int entierInferieur2 = (int)5.999999999;                // 5

            // int entierSuperieur = (int)Math.Ceiling(nombreVirgule);
            double doubleSuperieur = Math.Ceiling(5.0000001);       // 6
            int entierSuperieur1 = (int)Math.Ceiling(5.0000001);    // 6

            Math.Round(5.0000001); // valeur perdue

            // int entierPlusProche = (int)Math.Round(nombreVirgule);
            double doublePlusProche = Math.Round(5.0000001);        // < 0.5 => 5
            int entierPlusProche1 = (int)Math.Round(5.0000001);     // < 0.5 => 5
            int entierPlusProche2 = (int)Math.Round(5.49999999);    // < 0.5 => 5

            int entierPlusProche3 = (int)Math.Round(5.5);           // >= 0.5 => 6
            int entierPlusProche4 = (int)Math.Round(5.50000001);    // >= 0.5 => 6
            int entierPlusProche5 = (int)Math.Round(5.99999999);    // >= 0.5 => 6

            // double arrondiDecimale = Math.Round(nombreVirgule, decimale);
            double arrondi2Decimales = Math.Round(5.8745419, 2);    // 5.87
            double arrondi2Decimales2 = Math.Round(5.8754419, 2);   // 5.88

            double arrondi4Decimales = Math.Round(5.8745419, 4);    // 5.8745

            // --- Calculs scientifiques --- 
            // double puissance = Math.Pow(nombre, exposant);
            double puissance = Math.Pow(2, 8);      // 2^8
            double puissance2 = Math.Pow(3, 4);     // 3^4

            double puissance3 = Math.Pow(2, -10);   // 2^-10 = 1 / (2^10)

            // double racineCarree = Math.Sqrt(nombre);
            double racineCarree = Math.Sqrt(100);   // 10

            // double racineCubique = Math.Cbrt(nombre);
            double racineCubique = Math.Cbrt(8);    // 2 (2 * 2 * 2)

            // double racineApproximee = Math.Pow(nombre, 1 / radical);
            double racineErreur = Math.Pow(16, 1 / 4);          // 1 / 4 = 0 reste 1 = 0 => 16^0
            double racineQuadratique = Math.Pow(16, 1 / 4.0);   // 2 (2 * 2 * 2 * 2) => 16^0.25 = 16 radical 4

            // double ln = Math.Log(nombre); // Log e = ln
            double ln = Math.Log(100);
            double ln2 = Math.Log(10);
            double ln3 = Math.Log(1000);

            // double log2 = Math.Log2(nombre);
            double log2 = Math.Log2(100);

            // double log10 = Math.Log10(nombre);
            double log10 = Math.Log10(100);

            // double ePuissance = Math.Exp(nombre); // e^nombre, inverse de Math.Log
            double exp1 = Math.Exp(Math.Log(100));

            // --- Calcul des angles en radians --- 
            // Convertir un angle en dégrés en radians
            double angleDegres = 90;
            double radians = angleDegres * Math.PI / 180; // 2 * Pi / 360

            double sin = Math.Sin(radians);
            double cos = Math.Cos(radians);
            double tan = Math.Tan(radians);
            double arcsin = Math.Asin(radians); // sin-1
            double arccos = Math.Acos(radians); // cos-1
            double arctan = Math.Atan(radians); // tan-1

            /*****************************************
             * Génération de nombre aléatoire et tris
             ******************************************/

            // --- Classe Random ---
            // Génération de nombres aléatoires à l'aide d'un nombre initial (seed)
            Random generateurAleatoire = new Random();  // seed differente => nombres differents
            Random random = new Random();
            Random random2 = new Random();

            // Initialisation de la classe Random et du seed aléatoire
            // Même seed génère les mêmes nombres
            Random randomPredefini1 = new Random(12345678);
            Random randomPredefini2 = new Random(12345678);

            //int entierAleatoire = random.Next(min, max);      // [min, max[
            int entierAleatoire = random.Next(20, 30);          // [20, 30[
            Console.WriteLine(entierAleatoire);                 // seed aléatoire donc nombre aléatoire

            int entierPredefini = randomPredefini1.Next(20, 30);    // [20, 30[
            Console.WriteLine(entierPredefini);                     // 24 comme premier entier pour seed 12345678

            List<int> entiersAleatoires = new List<int>();
            for (int i = 0; i < 10; i++)
            {
                int entierAleatoire1A100 = random.Next(1, 100);  // [1, 100[
                entiersAleatoires.Add(entierAleatoire1A100);

                Console.Write($"{entierAleatoire1A100} ");
            }

            double doubleAleatoire = random.NextDouble();       // [0, 1[

            // double doubleMax = max * random.NextDouble();    // [0, max[
            double doubleMax1 = 8.5 * random.NextDouble();      // [0, 8.5[
            double doubleMax2 = 155.27 * random.NextDouble();   // [0, 155.27[

            // double doubleMinMax = min + (max – min) *random.NextDouble();    // [min, max[
            double doubleMinMax = 1.2 + (8.5 - 1.2) * random.NextDouble();      // [1.2, 8.5[

            // --- Classe List ---
            // Trier une liste en ordre croissant
            entiersAleatoires.Sort();

            Console.WriteLine();
            for (int i = 0; i < entiersAleatoires.Count; i++)
            {
                Console.Write($"{entiersAleatoires[i]} ");
            }

            // Mélanger le contenu d’une liste avec la librairie avancée Linq
            Random randomList = new Random();
            entiersAleatoires = entiersAleatoires.OrderBy(x => randomList.Next()).ToList();

            Console.WriteLine();
            for (int i = 0; i < entiersAleatoires.Count; i++)
            {
                Console.Write($"{entiersAleatoires[i]} ");
            }
        }

        private static void ExecuterExercice01()
        {
            double resultat1Fonction1 = ExecuterFonction1(0.12, 5);
            double resultat2Fonction1 = ExecuterFonction1(-2.52, 2);

            // TODO: Définir les autres fonctions et ajouter 2 tests
        }

        private static double ExecuterFonction1(double x, int y)
        {
            double resultat = 0; // TODO: Calculer à l'aide de la librairie Math

            return resultat;
        }
    }
}
