namespace Exercices.Week_3
{
    public static class XORStrings3
    {
        public static string Solution(string s, string t)
        {
            var res = string.Empty;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == t[i]) { res += "0"; continue; }
                res += "1";
            }

            return res;
        }
    }
}
