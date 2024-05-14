using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercices.Week_3
{
    public class PermutingTwoArrays
    {

        public static string Solution(int k, List<int> A, List<int> B)
        {
            var AC = A.OrderBy(a => a).ToList();
            var BC = B.OrderByDescending(b => b).ToList();

            var aux = 0;
            var result = string.Empty;
            for (int i = 0; i < A.Count; i++)
            {
                for (int j = A.Count - 1; j > i; j--)
                {
                    if (AC[i] + BC[j] >= k)
                    {
                        aux = BC[i];
                        BC[i] = BC[j];
                        BC[j] = aux;
                        break;
                    }
                }
                
            }

            for (int i = 0; i < A.Count; i++)
            {
                if (AC[i] + BC[i] < k)
                {
                    return "NO";
                }
            }

            return "YES"; 
        }
    }
}
