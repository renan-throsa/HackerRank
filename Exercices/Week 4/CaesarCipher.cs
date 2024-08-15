namespace Exercices.Week_4
{
    public class CaesarCipher
    {
        public static string Solution(string plaintext, int key)
        {
            string ciphertext = "";
            foreach (char letter in plaintext)
            {
                if (char.IsLetter(letter))
                {
                    char baseChar = char.IsUpper(letter) ? 'A' : 'a';
                    int shifted = (letter - baseChar + key) % 26;
                    ciphertext += (char)(baseChar + shifted);
                }
                else
                {
                    ciphertext += letter; // Keep non-letter characters unchanged
                }
            }
            return ciphertext;
        }
    }
}
