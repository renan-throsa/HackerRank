using System.Text.RegularExpressions;

namespace Exercices.Week_1
{
    public class CamelCase4
    {
        /// <summary>
        /// Camel Case is a naming style common in many programming languages. In Java, method and 
        /// variable names typically start with a lowercase letter, with all subsequent words 
        /// starting with a capital letter (example: startThread). Names of classes follow the same 
        /// pattern, except that they start with a capital letter (example: BlueCar).
        ///Your task is to write a program that creates or splits Camel Case variable, method, 
        ///and class names.
        /// </summary>
        public static string Solution(string s)
        {
            var data = s.Split(';');
            var operation = data[0];
            var type = data[1];
            var target = data[2];

            string pattern = @"(?<=.)(?=[A-Z])|\s";

            string[] substrings = Regex.Split(target, pattern);

            if (operation == "S")
            {
                var toToLower = substrings.Select(s => s.ToLower());
                var spaceAdded = toToLower.SkipLast(1).Select(s => s + " ");
                target = string.Join("", spaceAdded.Append(toToLower.Last()));
                target = target.Replace("(", "").Replace(")", "");
                return target;

            }

            if (operation == "C")
            {
                if (type == "C")
                {
                    return target = string.Join("", substrings.Select(s => s[..1].ToUpper() + s[1..].ToLower()));

                }

                var first = substrings.Take(1).Select(s => s.ToLower());
                var rest = substrings.Skip(1).Select(s => s[..1].ToUpper() + s[1..].ToLower());

                target = first.First() + string.Join("", rest);

                if (type == "M") { target += "()"; }

                return target;
            }

            return string.Empty;
        }
    }
}
