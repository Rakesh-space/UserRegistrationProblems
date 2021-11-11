using System;
using System.Text.RegularExpressions;

namespace UserRegistrationProblems
{
    class ValidatingRegex
    {
        //We are using this method to match pattern of first name
        public static void validFirstName(string name)
        {
                string firstname = "^[A-Z]{1}[a-zA-Z]{2}$";  //Expression for first letter is capital and maximum charactor is 3
                Regex regex = new Regex(firstname);

                if (regex.IsMatch(name))
                {
                    Console.WriteLine(name + "-->Valid");
                }
                else
                {
                    Console.WriteLine(name + "--->Invalid");
                }       
        }

        //We are using this method to match pattern of last name
        public static void LastName(string name)
        {
            string lastname = "^[A-Z]{1}[a-zA-Z]{2}$";      //Expression for first letter is capital and maximum charactor is 3
            Regex regex = new Regex(lastname);

            if (regex.IsMatch(name))
            {
                Console.WriteLine(name + "-->Valid");
            }
            else
            {
                Console.WriteLine(name + "--->Invalid");
            }
        }
    }
}
