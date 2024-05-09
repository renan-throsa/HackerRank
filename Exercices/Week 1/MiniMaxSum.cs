

using System;

namespace Exercices.Week_1
{
    public class MiniMaxSum
    {
        /// <summary>
        /// Given five positive integers, find the minimum and maximum values that can be calculated by 
        /// summing exactly four of the five integers. Then print the respective minimum and maximum values as
        /// a single line of two space-separated long integers.
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static long[] Solution(List<int> arr)
        {
            arr.Sort();
            var result = new long[2];
            result[0] = arr.SkipLast(1).Sum(x => (long)x);
            result[1] = arr.Skip(1).Sum(x => (long)x);
            return result;

        }
    }
}
