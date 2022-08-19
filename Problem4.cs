using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_handson
{
    internal class Problem4
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter first number: ");
            int i1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("enter second number: ");
            int i2 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("enter third number: ");
            int i3 = Int32.Parse(Console.ReadLine());
            int avg = (i1 + i2 + i3) / 3;
            Console.WriteLine("average of the number is : {0}", avg);
        }
    }
}
