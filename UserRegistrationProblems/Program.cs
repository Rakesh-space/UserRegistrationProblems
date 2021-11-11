using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRegistrationProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Regular Expression Program");
            Console.WriteLine();

            Console.Write("Enter First Name : ");   //taking user input of first name
            string firstname = Console.ReadLine();
            ValidatingRegex.FirstName(firstname);
            Console.ReadLine();

            Console.Write("Enter Last Name : ");   //taking user input of Last name
            string lastname = Console.ReadLine();
            ValidatingRegex.LastName(lastname);
            Console.ReadLine();

            Console.Write("Enter Email ID: ");   //taking user input of Email ID
            string Email = Console.ReadLine();
            ValidatingRegex.ValidEmail(Email);
            Console.ReadLine();

            Console.WriteLine("Enter mobile number in this format : 00 0000000000"); //taking user input of Mobile No
            string MobileNo = Console.ReadLine();
            ValidatingRegex.mobileFormat(MobileNo);
            Console.ReadLine();

            Console.Write("Enter Password: ");   //taking user input of password1
            string password1 = Console.ReadLine();
            ValidatingRegex.passwordFormat(password1);
            Console.ReadLine();

            Console.Write("Enter Upper Case Format Password: ");   //taking user input of uppser case format password1
            string password2 = Console.ReadLine();
            ValidatingRegex.UpperCaseFormat(password2);
            Console.ReadLine();

        }
    }
}
