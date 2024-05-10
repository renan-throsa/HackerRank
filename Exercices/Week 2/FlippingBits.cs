namespace Exercices.Week_2
{
    public class FlippingBits
    {
        /// <summary>
        /// You will be given a list of 32 bit unsigned integers. Flip all the bits (1 -> 0 and 0 -> 1) and return the result as an unsigned integer.
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static long Solution(long n)
        {
            return (uint)~n;
        }
    }
}
