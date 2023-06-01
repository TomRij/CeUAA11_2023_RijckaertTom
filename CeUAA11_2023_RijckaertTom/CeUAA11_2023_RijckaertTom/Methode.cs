using System;
using System.Collections.Generic;
using System.Text;

namespace CeUAA11_2023_RijckaertTom
{
    struct Methode
    {
        /// <summary>
        /// Créer la matrice de cryptage de la phrase phClaire grâce à la clef phClef avec la méthode de Vigenère.
        /// </summary>
        /// <param name="phClaire">phrase à crypter</param>
        /// <param name="phClef">clef de cryptage</param>
        /// <param name="MatVigenere">Matrice de cryptage de Vigenère</param>
        public void CryptVignere(string phClaire, string phClef, out string[,] MatVigenere)
        {
            MatVigenere = new string[4, phClaire.Length];
            int codeAscii;
            int j = 0;
            for (int i = 0; i < phClaire.Length; i++)
            {
                MatVigenere[1, i] = phClef[i].ToString();
                if (j == phClef.Length)
                {
                    j = 0;
                }
                MatVigenere[1, i] = phClef[j].ToString();
                MatVigenere[2, i] = (((int)phClef[j]) - 65).ToString();
                if ((int)phClaire[i] + int.Parse(MatVigenere[2, i]) <= 90)
                {
                    codeAscii = (int)char.Parse(MatVigenere[0, i]) + int.Parse(MatVigenere[2, i]);
                }
                else
                {
                    codeAscii = (int)char.Parse(MatVigenere[0, i]) + int.Parse(MatVigenere[2, i])- 26;
                }
                MatVigenere[3, i] = Convert.ToChar(codeAscii).ToString();
                j += 1;
            }
        }
        /// <summary>
        /// Créer la matrice de cryptage de phClaire avec la méthode affine.
        /// </summary>
        /// <param name="phClaire">phrase à crypter</param>
        /// <param name="a">1° coefficient du cryptage</param>
        /// <param name="b">2° coefficient du cryptage</param>
        /// <param name="matAffine">matrice de cryptage affine</param>
        public void CryptAffine(string phClaire, int a, int b, out string[,] matAffine)
        {
            int x;
            int y;
            matAffine = new string[4, phClaire.Length];
            for (int i = 0; i < phClaire.Length; i++)
            {
                matAffine[0, i] = phClaire[i].ToString();
                x = ((int)phClaire[i] - 65);
                matAffine[1, i] = x.ToString();
                y = (a * x + b) % 26;
                matAffine[2, i] = y.ToString();
                matAffine[3, i] = y + 65.ToString();
            }
        }
        /// <summary>
        /// Concaténer la Matrice
        /// </summary>
        /// <param name="Tab">Matrice à concaténer</param>
        /// <param name="stringTab">Matrice Concaténé</param>
        public void String_Tableau(string[,] Tab, out string stringTab)
        {
            // instanciation de la variable stringTab
            stringTab = "";
            // boucle pour se balades dans les lignes de la matrice
            for (int ligne = 0; ligne < Tab.GetLength(0); ligne++)
            {
                // boucle pour se balader dans les colonnes de la matrice
                for (int colonne = 0; colonne < Tab.GetLength(1); colonne++)
                {
                    // mise des données de la matrice dans la variable string stringTab
                    stringTab += Tab[ligne, colonne] + "|";
                }
                // passage à la ligne
                stringTab += "\n";
            }
        }

        /// <summary>
        /// Concaténer la Matrice
        /// </summary>
        /// <param name="Tab">Matrice à concaténer</param>
        /// <param name="stringTab">Matrice Concaténé</param>
        public void String_Last_Tableau(string[,] Tab, out string stringTab)
        {
            // instanciation de la variable stringTab
            stringTab = "";
            // boucle pour se balades dans les lignes de la matrice
            for (int ligne = 3; ligne < Tab.GetLength(0); ligne++)
            {
                // boucle pour se balader dans les colonnes de la matrice
                for (int colonne = 0; colonne < Tab.GetLength(1); colonne++)
                {
                    // mise des données de la matrice dans la variable string stringTab
                    stringTab += Tab[ligne, colonne] + "|";
                }
                // passage à la ligne
                stringTab += "\n";
            }
        }
    }
}
