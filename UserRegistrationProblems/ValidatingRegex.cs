using System;
using System.Text.RegularExpressions;

namespace UserRegistrationProblems
{
    class ValidatingRegex
    {


        //We are using this method to match pattern of first name
        public static void FirstName(string name)
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
        //This method for validation of email id
        public static void ValidEmail(string mail)
        {
            string emailid = "^[a-z]{3}[.][a-z0-9]*[@]{1}[bl]{2}[.]{1}[co]{2}[.]{1}[a-z]*$";  //Expression for Validating Email
            Regex regex = new Regex(emailid);

            if (regex.IsMatch(mail))
            {
                Console.WriteLine(mail + "-- > Valid");
            }
            else
            {
                Console.WriteLine(mail + "-- > InValid");
            }

        }

        //We are using this method to match pattern of mobile no
        public static void mobileFormat(string number)
        {
            string Mobnumber = "^[0-9]{1,2}[ ]{1}[0-9]{10}$";  //Expression for Validating mobileFormating
            Regex regex = new Regex(Mobnumber);

            if (regex.IsMatch(number))
            {
                Console.WriteLine(number + "-- > Valid");
            }
            else
            {
                Console.WriteLine(number + "-- > InValid");
            }

        }


        //We are using this method to match pattern of password format
        public static void passwordFormat(string pass)
        {
            string pwd = "^[a-zA-Z0-9]{8,}$";
            Regex regex = new Regex(pwd);        //Expression for Validating regular Password format
            if (regex.IsMatch(pass))
            {
                Console.WriteLine(pass + "-- > Valid");
            }
            else
                Console.WriteLine(pass + "-- > InValid");
        }

        //We are using this method to match pattern of Upper Case Password format
        public static void UpperCaseFormat(string pass)
        {
            string pwd = "^(?=.*[A-Z])[a-zA-Z0-9]{8,}$"; //Expression for Validating Upper Case Password format
            Regex regex = new Regex(pwd);
            if (regex.IsMatch(pass))
            {
                Console.WriteLine(pass + "-- > Valid");
            }
            else
            {
                Console.WriteLine(pass + "-- > InValid");
            }
        }

        //We are using this method to match pattern of One Numeric Password format
        public static void OneNumeric(string pass)
        {
            string pwd = "^(?=.*[A-Z])(?=.*[0-9])[a-zA-Z0-9]{8,}$";  //Expression for Validating One Numeric Password format
            Regex regex = new Regex(pwd);
            if (regex.IsMatch(pass))
            {
                Console.WriteLine(pass + "-- > Valid");
            }
            else
            {
                Console.WriteLine(pass + "-- > InValid");
            }
        }

        //We are using this method to match pattern of Special Charcter Password format
        public static void SpecialCharcter(string pass)
        {
            string pwd = "^(?=.*[a-z])(?=.*[A-Z])(?=.*[0-9])(?=.*[^a-zA-Z0-9]).{8,}$"; //Expression for Validating Special Character Password format
            Regex regex = new Regex(pwd);
            if (regex.IsMatch(pass))
            {
                Console.WriteLine(pass + "-- > Valid");
            }
            else
            {
                Console.WriteLine(pass + "-- > InValid");
            }        
        }
    }
}
