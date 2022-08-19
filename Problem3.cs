using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_handson
{
    internal class Problem3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter first number: ");
            int i1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("enter second number: ");
            int j2 = Int32.Parse(Console.ReadLine());
            int add = i1 + j2;
            int sub = i1 - j2;
            int div = i1 / j2;
            int mul = i1 * j2;
            int mod = i1 % j2;

            Console.WriteLine("addition:{0}",add);
            Console.WriteLine("substraction:{0}", sub);
            Console.WriteLine("multiplication:{0}", mul);
            Console.WriteLine("division:{0}", div);
            Console.WriteLine("modulus:{0}", mod);
        }
    }
}
