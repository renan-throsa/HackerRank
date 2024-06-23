namespace Exercices.Week_4
{
    public class PickingNumbers
    {
        /// <summary>
        /// Given an array of integers, find the longest subarray where the absolute difference between any two elements is less than or equal to 1.
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public static int Solution(List<int> a)
        {
            //Note that there is a discrepancy between the problem description and what the test cases actually want.
            a.Sort();

            int maxi = 0;
            for (int i = 0; i < a.Count; i++)
            {
                int count = 1;
                for (int j = i + 1; j < a.Count; j++)
                {
                    if (Math.Abs(a[i] - a[j]) <= 1)
                    {
                        count++;
                    }
                    else
                    {
                        break;
                    }
                }
                maxi = Math.Max(maxi, count);
            }

            return maxi;

        }
    }
}
