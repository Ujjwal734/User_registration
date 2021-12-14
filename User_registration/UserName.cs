using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace User_registration
{
    public class UserName
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name :- ");
            string instr = Console.ReadLine();
            const string name = @"^[A-Z]{1}[a-z]{3,9}$";

            Regex rg = new Regex(name);
            Console.WriteLine(rg.IsMatch(instr));
        }
    }
}
