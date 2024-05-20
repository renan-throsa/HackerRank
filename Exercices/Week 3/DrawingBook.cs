using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercices.Week_3
{
    public class DrawingBook
    {
        public static int Solution(int n, int p)
        {
            return Math.Min(p / 2, n / 2 - p / 2);
        }
    }
}
