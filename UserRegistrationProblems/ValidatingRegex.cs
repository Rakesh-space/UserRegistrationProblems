using System;
using System.Text.RegularExpressions;

namespace UserRegistrationProblems
{
    class ValidatingRegex
    {
        public static void passowordFormat()
        {
            string[] inputs = { "Rakesh@5" };
            string pattern = "^[A-Za-z]{6,}@?[0-9]{1,}$";

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
            passowordFormat();
        }

    }
}
