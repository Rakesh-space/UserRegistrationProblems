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

             //We are using this method to match differnt pattern of Email format
            public static void EmailArr(string[] name)
            {
                string email = "^[a-zA-Z0-9]+[+-._]{0,1}[a-zA-Z0-9]*[+-._]?[a-zA-Z0-9]*[@][a-zA-Z0-9]+[.][a-zA-Z0-9]{2,3}([.]?[a-zA-Z]{2,3}){0,1}$";
                //+ means one or more.
                //*- zero or more.
                //?- zero or 1 

                Regex regex = new Regex(email);      //Expression for Validating regular exp email different format.
                foreach (var word in name)
                {
                    if (regex.IsMatch(word))
                    {
                        Console.WriteLine(word + " is valid.");
                    }
                    else
                    {
                        Console.WriteLine(word + " is invalid.");
                    }
                }

            }
    }
}
