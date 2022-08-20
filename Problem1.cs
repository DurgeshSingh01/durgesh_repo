using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _19th_handson
{
    internal class Problem1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number");
            int i = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number");
            int j = Convert.ToInt32(Console.ReadLine());
            if (i > j)
            {
                Console.WriteLine("Maximum Number: " +i);
                Console.WriteLine("Minimum Number: " + j);

            }
            else
            {
                Console.WriteLine("Maximum Number: " + j);
                Console.WriteLine("Minimum Number: " + i);
            }
            
            Console.ReadLine();
        }
    }
}
