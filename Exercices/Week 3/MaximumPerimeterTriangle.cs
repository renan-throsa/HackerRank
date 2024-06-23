namespace Exercices.Week_3
{
    public class MaximumPerimeterTriangle
    {
        /// <summary>
        /// For a triangle to be non-degenerate, the sum of the measures of the two shorter sides must be greater than the measure of the longer side. a + b > c
        /// </summary>
        /// <param name="sticks"></param>
        /// <returns></returns>
        public static List<int> Solution(List<int> sticks)
        {
            sticks = sticks.OrderByDescending(x => x).ToList();
            for (int i = 0; i < sticks.Count() - 2; i++)
            {
                if (sticks[i + 2] + sticks[i + 1] > sticks[i])
                {
                    return new List<int> { sticks[i + 2], sticks[i + 1], sticks[i] };
                }
            }
            return new List<int>() { -1 };
        }
    }
}
