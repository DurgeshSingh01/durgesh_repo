using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_handson
{
    internal class AdditionalProblem
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first name");
            string str = Console.ReadLine();
            Console.WriteLine("Enter the last name");
            string str1 = Console.ReadLine();
            if (string.IsNullOrEmpty(str) && string.IsNullOrEmpty(str1))
            {
                Console.WriteLine("Enter a valid FirstName and lastName");
            }
            else
                Console.WriteLine($"Welcome to my app {str} {str1}");
            Console.ReadLine();
        }
    }
}
