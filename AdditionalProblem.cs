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
            Console.WriteLine("Enter the user name");
            string str = Console.ReadLine();
            if (string.IsNullOrEmpty(str))
            {
                Console.WriteLine("Enter a valid user name");
            }
            else
                Console.WriteLine("Hello " + str);
        }
    }
}
