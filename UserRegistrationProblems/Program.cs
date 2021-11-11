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
            ValidatingRegex.validFirstName(firstname);
            Console.ReadLine();

            Console.Write("Enter Last Name : ");   //taking user input of Last name
            string lastname = Console.ReadLine();
            ValidatingRegex.LastName(lastname);
            Console.ReadLine();

        }
    }
}
