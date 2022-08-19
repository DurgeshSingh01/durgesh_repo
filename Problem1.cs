using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_handson
{
    internal class Problem1
    {
        static void Main(string[] args)
        {
            int i = Int32.Parse(Console.ReadLine());
            int j = Int32.Parse(Console.ReadLine());
            int k;
            k = i;
            i = j;
            j = k;
            Console.WriteLine("----nuber after swapping----");
            Console.WriteLine("first number: {i}");
            Console.WriteLine("first number: {i}");
        }
    }
}
