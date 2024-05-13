
namespace Exercices.Week_2
{
    public class CountingValleys
    {
        public static int Solution(string path)
        {
            int count = 0;
            int res = 0;
            foreach (char c in path)
            {
                if (c == 'U')
                {
                    count++;
                }
                else
                {
                    count--;
                }
                if (count == 0 && c == 'U')
                {
                    res++;
                }
            }
            return res;
        }
        
    }
}
