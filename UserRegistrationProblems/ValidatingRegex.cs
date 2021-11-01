using System;
using System.Text.RegularExpressions;

namespace UserRegistrationProblems
{
    class ValidatingRegex
    {
        public static void UpperCaseFormat()
        {
            string[] inputs = { "RAKESH@195" };
            string pattern = "^[A-Z]{6,}@?[0-9]{3,}$";

            Regex regex = new Regex(pattern);

            foreach (string word in inputs)
            {
                if (regex.IsMatch(word))
                {
                    Console.WriteLine(word + "-->Valid");
                }
                else
                {
                    Console.WriteLine(word + "--->Invalid");
                }
            }
        }
        static void Main(string[] args)
        {
            UpperCaseFormat();
        }

    }
}
