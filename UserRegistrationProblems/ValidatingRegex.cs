using System;
using System.Text.RegularExpressions;

namespace UserRegistrationProblems
{
    class ValidatingRegex
    {
        public static void validLastName()
        {
            string[] inputs = { "Musale" };
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
            validLastName();
        }

    }
}
