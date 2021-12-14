using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace User_registration
{
    public class Lastname
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your Last name :- ");
            string inStr = Console.ReadLine();
            const string lastname = @"^[A-Z]{1}[a-z]{3,10}$";

            Regex rg = new Regex(lastname);
            Console.WriteLine(rg.IsMatch(inStr));
        }
    }
}
