namespace Exercices.Week_2
{
    public class Pangrams
    {
        /// <summary>
        /// A pangram is a string that contains every letter of the alphabet. Given a sentence determine whether it is a pangram in the English alphabet. Ignore case. Return either pangram or not pangram as appropriate.
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static string Solution(string s)
        {
            for (char c = 'a'; c <= 'z'; c++)
            {
                if (!s.Contains(c, StringComparison.OrdinalIgnoreCase)) { return "not pangram"; }                
            }

            return "pangram";
        }
    }
}
