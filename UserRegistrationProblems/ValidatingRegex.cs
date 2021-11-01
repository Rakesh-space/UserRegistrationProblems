using System;
using System.Text.RegularExpressions;

namespace UserRegistrationProblems
{
    class ValidatingRegex
    {
        public static void mobileFormat()
        {
            string[] inputs = { "91 8007078569" };
            string pattern = "^[a-z0-9]{2,} [0-9]{10}$";

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
            mobileFormat();
        }

    }
}
