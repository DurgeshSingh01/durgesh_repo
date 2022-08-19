using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_handson
{
    internal class problem5
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter first number: ");
            int i1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("enter second number: ");
            int i2 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("enter third number: ");
            int i3 = Int32.Parse(Console.ReadLine());
            int res1 = (i1 + i2) * i3;
            int res2 = (i1 * i3) + (i2 * i3);
            Console.WriteLine("output: {0} and {1}", res1, res2);
        }
    }
}
