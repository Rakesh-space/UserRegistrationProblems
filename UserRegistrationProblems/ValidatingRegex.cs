using System;
using System.Text.RegularExpressions;

namespace UserRegistrationProblems
{
    class ValidatingRegex
    {
        public static void OneNumeric()
        {
            string[] inputs = { "5Rakesh@195" };
            string pattern = "^[0-9]{1,}[a-zA-Z]{6,}@?[0-9]{3,}$";

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
            OneNumeric();
        }

    }
}
