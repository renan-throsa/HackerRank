namespace Exercices.Week_3
{
    public class MigratoryBirds
    {
        /// <summary>
        /// Given an array of bird sightings where every element represents a bird type id, determine the id of the most frequently sighted type. 
        /// If more than 1 type has been spotted that maximum amount, return the smallest of their ids.
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static int Solution(List<int> arr)
        {  
            return arr.GroupBy(x => x).Select(g => new { I = g.Key, Count = g.Count() }).OrderByDescending(x => x.Count).ThenBy(x => x.I).First().I;
        }
    }
}
