using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_handson
{
    internal class problem2
    {
        static void Main(string[] args)
        {
            int i = Int32.Parse(Console.ReadLine());
            int j = Int32.Parse(Console.ReadLine());
            int k = Int32.Parse(Console.ReadLine());
            int res = i * j * k;
            Console.WriteLine(res);
        }
    }
}
