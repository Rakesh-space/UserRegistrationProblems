using System;
using System.Text.RegularExpressions;

namespace UserRegistrationProblems
{
    class ValidatingRegex
    {
        public static void validEmail()
        {
            string[] inputs = { "rakeshmusale111@gmail.com" };
            string pattern = "^[a-z0-9]{15}@?gmail.com$";

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
            validEmail();
        }

    }
}
