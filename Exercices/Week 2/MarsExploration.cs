using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercices.Week_2
{
    public class MarsExploration
    {
        /// <summary>
        /// A space explorer's ship crashed on Mars! They send a series of SOS messages to Earth for help.
        /// Letters in some of the SOS messages are altered by cosmic radiation during transmission. Given the signal received by Earth as a string 's' determine how many letters of the SOS message have been changed by radiation.
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static int Solution(string s)
        {
            var result = new int[s.Count()];
            var expected = OriginalMessage(s);
            for (int i = 0; i < s.Count(); i++)
            {

                result[i] = s[i] == expected[i] ? 0 : 1;
            }

            return result.Sum();
        }

        public static string OriginalMessage(string s)
        {

            var expected = string.Empty;
            while (expected.Count() < s.Count())
            {
                expected += "SOS";
            }
            return expected;
        }
    }
}
