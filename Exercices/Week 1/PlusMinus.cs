

namespace Exercices.Week_1
{
    public static class PlusMinus
    {
        /// <summary>
        /// Given an array of integers, calculate the ratios of its elements that are positive, negative, and zero. 
        /// Return the decimal value of each fraction on a new line with  places after the decimal.
        /// </summary>
        /// <param name="arr"></param>
        public static double[] Solution(List<int> arr)
        {
            var count = arr.Count();
            var result = new double[3];
            
            result[0] = (double) arr.Count(x => x > 0) / count;
            result[1] = (double) arr.Count(x => x < 0) / count;
            result[2] = (double) arr.Count(x => x == 0) / count;

            return result;

        }
    }
}
