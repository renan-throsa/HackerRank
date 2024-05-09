using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercices.Week_1
{
    public class BreakingtheRecords
    {
        /// <summary>
        /// Maria plays college basketball and wants to go pro. Each season she maintains a 
        /// record of her play. She tabulates the number of times she breaks her season record 
        /// for most points and least points in a game. Points scored in the first game establish 
        /// her record for the season, and she begins counting from there.
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public static int[] Solution(int[] scores)
        {
            var max = scores[0];
            var min = scores[0];
            var maxCount = 0;
            var minCount = 0;

            for (int i = 1; i < scores.Count(); i++)
            {
                if (scores[i] > max) { max = scores[i]; maxCount++; }
                if (scores[i] < min) { min = scores[i]; minCount++; }
            }

            return new int[2] { maxCount, minCount };
        }
    }
}
