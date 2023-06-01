using System;

namespace CeUAA11_2023_RijckaertTom
{
    class Program
    {
        /// <summary>
        /// Faire deux cryptages :
        /// - cryptage Vigenère
        /// - cryptage Affine
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Methode MesOutils = new Methode();
            string choix = "";
            Console.WriteLine("CRYPTAGE\n********");


            while (true)
            {
                Console.WriteLine("Choisissez parmi les options suivantes :\n1 - Cryptage de Vigenère\n2 - Cryptage avec la méthode affine");
                choix = Console.ReadLine();

                switch (choix)
                {
                    // Le Cryptage de Vigenère
                    case "1":
                        Console.WriteLine("Entrer la phrase à crypter !");
                        string phClaire = Console.ReadLine();

                        Console.WriteLine("Entrer la clef !");
                        string phClef = Console.ReadLine();
                        Console.WriteLine("---------------------------");
                        Console.WriteLine("Oups un problème est arrivé");
                        Console.WriteLine("---------------------------");
                        //  MesOutils.CryptVignere(phClaire, phClef, out string[,] MatVigenere);
                        // MesOutils.String_Tableau(MatVigenere, out string stringTab);
                        // Console.WriteLine(stringTab);
                        break;

                    // Le Cryptage de la méthode affine
                    case "2":
                        Console.WriteLine("Encoder la phrase à crypter !");
                        phClaire = Console.ReadLine();
                        Console.WriteLine("Donnez la valeur du coefficiant a (impair entre 1 et 25 sauf 13)");
                        int a = int.Parse(Console.ReadLine());
                        Console.WriteLine("Donnez la valeur du coefficiant b (impair entre 1 et 25 sauf 13)");
                        int b = int.Parse(Console.ReadLine());
                        MesOutils.CryptAffine(phClaire, a, b, out string[,] matAffine);
                        MesOutils.String_Tableau(matAffine, out string stringTab);
                        MesOutils.String_Last_Tableau(matAffine, out string stringTab2);
                        Console.WriteLine("La Matrice complète !");
                        Console.WriteLine("--------------------------------------------------------");
                        Console.WriteLine(stringTab);
                        Console.WriteLine("--------------------------------------------------------");
                        Console.WriteLine("La phrase crypter !");
                        Console.WriteLine("=========================================================");
                        Console.WriteLine(stringTab2);
                        Console.WriteLine("=========================================================");

                        break;

                    default:
                        Console.WriteLine("Vous avez oublié de choisier quelque chose !");
                        break;
                }
                Console.WriteLine("Voulez vous recommencer (o/oui ou n/non");
                string recom = Console.ReadLine();
                if (recom == "n" || recom == "non")
                {
                    break;
                }
            }
        }
    }
}
