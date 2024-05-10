namespace Exercices.Week_1
{
    public class DivisibleSumPairs
    {
        public static int Solution(int k, int[] ar)
        {
            int count = 0;
            for (int i = 0; i < ar.Count(); i++)
            {
                for (int j = i + 1; j < ar.Count(); j++)
                {
                    if ((ar[i] + ar[j]) % k == 0)
                    {
                        count++;
                    }
                }
            }
            return count;
        }
    }
}
