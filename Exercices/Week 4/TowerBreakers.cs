namespace Exercices.Week_4
{
    public class TowerBreakers
    {
        public static int Solution(int n, int m)
        {
            if (m == 1 || n % 2 == 0)
            {
                return 2;
            }
            else
            {
                return 1;
            }
        }
        
    }
}
