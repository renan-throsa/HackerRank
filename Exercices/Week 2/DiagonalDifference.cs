namespace Exercices.Week_2
{
    public class DiagonalDifference
    {
        /// <summary>
        /// Given a square matrix, calculate the absolute difference between the sums of its diagonals.
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static int Solution(List<List<int>> arr)
        {
            int leftToRight = 0;
            int rightToLeft = 0;

            int i, j;

            for (i = 0, j = arr.Count - 1; i < arr.Count; i++)
            {
                leftToRight += arr[i][i];
                rightToLeft += arr[i][j--];
            }


            if (leftToRight - rightToLeft < 0)
            {
                return (leftToRight - rightToLeft) * -1;
            }
            return leftToRight - rightToLeft;
        }
    }
}
