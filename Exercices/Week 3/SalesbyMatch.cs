namespace Exercices.Week_3
{
    public class SalesbyMatch
    {
        /// <summary>
        /// There is a large pile of socks that must be paired by color. Given an array of integers representing the
        /// color of each sock, determine how many pairs of socks with matching colors there are.
        /// </summary>
        /// <param name="ar"></param>
        /// <returns></returns>
        public static int Solution(List<int> ar)
        {

            return (ar.GroupBy(x => x)
                     .Select(x => x.ToList().Count())
                     .Select(x => x % 2 == 0 ? x : x - (x % 2))
                     .Sum()/2);

        }
    }
}
