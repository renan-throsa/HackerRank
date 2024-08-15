using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercices.Week_4
{
    public class ClosestNumbers
    {

        /// <summary>
        /// Sorting is useful as the first step in many different tasks. The most common task is to make finding things easier, but there are other uses as well. 
        /// In this case, it will make it easier to determine which pair or pairs of elements have the smallest absolute difference between them.
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static List<int> Solution(List<int> arr)
        {
            arr.Sort();
            int smalllet = smallestDifference(arr);
            List<int> result = new List<int>();
            for (int i = 0; i < arr.Count - 1; i++)
            {
                if (arr[i + 1] - arr[i] == smalllet)
                {
                    result.Add(arr[i]);
                    result.Add(arr[i+1]);
                }
            }

            return result;
        }


        private static int smallestDifference(List<int> arr)
        {
            int smallestDifference = int.MaxValue;

            for (int i = 0; i < arr.Count - 1; i++)
            {
                if (arr[i + 1] - arr[i] < smallestDifference)
                {
                    smallestDifference = arr[i + 1] - arr[i];
                }
            }

            return smallestDifference;
        }
    }
}
