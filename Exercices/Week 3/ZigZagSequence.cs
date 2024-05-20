namespace Exercices.Week_3
{
    public class ZigZagSequence
    {
        public static int[] Solution(int[] a)
        {
            a = a.OrderBy(x => x).ToArray();
            int n = a.Count();
            int mid = ((n + 1) / 2) - 1;

            int temp = a[mid];
            a[mid] = a[n - 1];
            a[n - 1] = temp;

            int st = mid + 1;
            int ed = n - 2;
            while (st <= ed)
            {
                temp = a[st];
                a[st] = a[ed];
                a[ed] = temp;
                st++;
                ed--;
            }

            return a;
        }
    }
}
