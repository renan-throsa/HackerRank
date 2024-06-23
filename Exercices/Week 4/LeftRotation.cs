namespace Exercices.Week_4
{
    public static class LeftRotation
    {
        /// <summary>
        /// A left rotation operation on an array of size n shifts each of the array's elements 1 
        /// unit to the left. Given an integer, d, rotate the array that many steps left and return 
        /// the result.
        /// </summary>
        /// <param name="d"></param>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static List<int> Solution(int d, List<int> arr)
        {

            var left = arr.Take(d);
            var right = arr.Skip(d);
            return right.Concat(left).ToList();

        }
    }
}
