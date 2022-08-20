using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19th_handson
{
    internal class Problem9
    {
        static void Main()
        {
            int n, sum = 0;
            Console.Write("Input number of terms : ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.Write("The odd numbers are :");
            for (int i = 1; i <= n; i++)
            {
                Console.Write("{0} ", 2 * i - 1);
                sum += (2 * i) - 1;
            }
            Console.Write("The Sum of odd Natural Number upto {0} terms : {1}", n, sum);
            Console.ReadLine();

        }
    }
}
