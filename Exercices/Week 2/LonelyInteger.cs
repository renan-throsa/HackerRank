using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercices.Week_2
{
    public class LonelyInteger
    {
        /// <summary>
        /// Given an array of integers, where all elements but one occur twice, find the unique element.
        /// </summary>
        /// <param name="numbers"></param>
        /// <returns></returns>
        public static int Solution(List<int> numbers)
        {
            var unique = numbers.GroupBy(n => n).Single(g => g.Count() == 1).Key;
            return unique;
        }
    }
}
