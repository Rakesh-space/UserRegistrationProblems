using System;
using System.Text.RegularExpressions;

namespace UserRegistrationProblems
{
    class ValidatingRegex
    {
        public static void validFirstName()
        {
            string[] inputs = { "Rakesh" };
            string pattern = "^[A-Za-z]{3,}$";

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
            Console.WriteLine("\n Welcome User Registration Problem..");
        }

    }
}
