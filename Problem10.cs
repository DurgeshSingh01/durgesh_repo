using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_handson
{
    internal class Problem10
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter first number: ");
            int i1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("enter second number: ");
            int i2 = Int32.Parse(Console.ReadLine());
            if (i1< 0 && i2> 0)
            {
                Console.WriteLine("True");
            }
        }
    }
}
