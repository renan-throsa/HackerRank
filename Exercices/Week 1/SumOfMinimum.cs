namespace Exercices.Week_1
{
    public static class SumOfMinimum
    {
        public static int Solution(int[][] matriz)
        {
            int sum = 0;
            for (int i = 0; i < matriz.Length; i++)
            {
                var current = new int[matriz[i].Length];

                for (int j = 0; j < matriz[i].Length; j++)
                {
                    current[j] = matriz[i][j];
                }
                sum += getMinium(current);
            }

            return sum;
        }

        private static int getMinium(int[] array)
        {
            int min = array[0];

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                }
            }

            return min;
        }
    }
}
