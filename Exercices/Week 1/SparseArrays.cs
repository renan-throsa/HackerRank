using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercices.Week_1
{
    public class SparseArrays
    {
        /// <summary>
        /// There is a collection of input strings and a collection of query strings. For each query string, 
        /// determine how many times it occurs in the list of input strings. Return an array of the results.
        /// </summary>
        /// <param name="strings"></param>
        /// <param name="queries"></param>
        /// <returns></returns>
        public static List<int> Solution(List<string> strings, List<string> queries)
        {
            var result = new List<int> { };
            foreach (var q in queries)
            {                
                result.Add(strings.Where(s => s.Equals(q)).Count());
            }
            
            return result;
        }
    }
}
