using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19th_handson
{
    internal class Problem4
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first sting: ");
            string str1 = Console.ReadLine();
            Console.WriteLine("Enter second sting: ");
            string str2 = Console.ReadLine();
            if (str1 == str2)
            {
                Console.WriteLine("Both string are equal");
            }
            else
                Console.WriteLine("Both string is not equal");
            Console.ReadLine();
        }
    }
}
