 namespace Exercices.Week_4
{
    public static class NumberLineJumps
    {
        /// <summary>
        /// You are choreographing a circus show with various animals. For one act, you are given
        /// two kangaroos on a number line ready to jump in the positive direction (i.e, toward positive infinity).
        /// The first kangaroo starts at location x1 and moves at a rate of v1 meters per jump.
        /// The second kangaroo starts at location x2 and moves at a rate of v2 meters per jump.
        /// You have to figure out a way to get both kangaroos at the same location at the same time 
        /// as part of the show. If it is possible, return YES, otherwise return NO.
        /// </summary>
        /// <param name="x1"></param>
        /// <param name="v1"></param>
        /// <param name="x2"></param>
        /// <param name="v2"></param>
        /// <returns></returns>
        public static string Solution(int x1, int v1, int x2, int v2)
        {

            /*
                K1 = distance = x1 + (v2 * j)
                K2 = distance = x2 + (v2 * j)

                K1 = x1 + (v2 * j) = K2 = x2 + (v2 * j)

                x1 + (v2 * j) = x2 + (v2 * j)

                (v1 * j)-(v2 * j) = x2 - x1
                (v1 - v2) *j = x2 - x1
                j = (x2 - x1) / (v1 - v2)

                Since a kangaroo cannot make a fractional jump j, the result of the division must be
                an integer. With that in mind, we need to know weather (x2 - x1) % (v1 - v2) = 0.
                If so, the answer is 'YES'. No, otherwise.
           
             */

            // Constraint: 0 <= x1 <= x2. In other words, k2 always starts ahead of k1.
            // Thus, if different k1 will never reatch k2.
            if (v1 <= v2)
                return "NO";

            if ((x2 - x1) % (v1 - v2) == 0)
                return "YES";
            else
                return "NO";

        }
    }
}
