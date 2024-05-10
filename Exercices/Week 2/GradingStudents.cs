

namespace Exercices.Week_2
{
    public class GradingStudents
    {
        public static List<int> Solution(List<int> grades)
        {
            for (int i = 0; i < grades.Count; i++)
            {
                if (grades[i] < 38) continue;

                var grade = grades[i];
                var multiple = NextMultipleOfFive(grade);
                if (multiple - grade < 3)
                {
                    grades[i] = multiple;
                }

            }

            return grades;
           
        }

        public static int NextMultipleOfFive(int grade)
        {
            int next = grade;
            while(next % 5 != 0) {
                next++;
            }
            return next;
        }
    }
}
