namespace Exercices.Week_4
{
    public static class SeparatetheNumbers
    {
        public static string Next(this string s)
        {
            var num = long.Parse(s);
            num++;
            return num.ToString();
        }

        public static string Solution(string s)
        {
            for (var toPosition = 1; toPosition <= s.Length / 2; toPosition++)
            {
                var fromPosition = 0;
                var current = s.Substring(fromPosition, toPosition);

                while (fromPosition + current.Length <= s.Length && s.Substring(fromPosition, current.Length) == current)
                {
                    fromPosition += current.Length;
                    current = current.Next();
                }

                if (fromPosition == s.Length)
                {
                    return $"YES {s.Substring(0, toPosition)}";
                }
            }

            return "NO";
        }
    }

}

