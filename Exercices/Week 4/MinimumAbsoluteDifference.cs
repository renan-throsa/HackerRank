namespace Exercices.Week_4
{
    public class MinimumAbsoluteDifference
    {
        public static int Solution(List<int> arr)
        {
            var orderredArray = arr.OrderBy(x => x).ToList();
            // Order the array elements and convert to a list
            var smallest = int.MaxValue;

            for (int i = 0; i < orderredArray.Count() - 1; i++)
            {
                if (Math.Abs(orderredArray[i + 1] - orderredArray[i]) < smallest)
                {
                    smallest = Math.Abs(orderredArray[i + 1] - orderredArray[i]);
                }
            }            

            return smallest;            
        }
    }
}
