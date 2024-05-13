namespace Exercices.Week_2
{
    public class CountingSort1
    {
        /// <summary>
        /// Another sorting method, the counting sort, does not require comparison. Instead, you create an integer
        /// array whose index range covers the entire range of values in your array to sort. Each time a value occurs 
        /// in the original array, you increment the counter at that index. At the end, run through your counting array,
        /// printing the value of each non-zero valued index that number of times.
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static List<int> Solution(List<int> arr)
        {
            var range = new List<int>(new int[arr.Max()+1]);

            for (int i = 0; i < arr.Count(); i++)
            {
                var n = arr[i];
                range[n] += 1;
            }

            return range.Where(x => x > 0).ToList();

        }
    }
}
