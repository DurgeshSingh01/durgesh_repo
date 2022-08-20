using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19th_handson
{
    internal class Problem10
    {
        static void Main()
        {
            int num, sum = 0, r, t;
            Console.Write("Input a number:");
            num = Convert.ToInt32(Console.ReadLine());

            for (t = num; t != 0; t = t / 10)
            {
                r = t % 10;
                sum = sum * 10 + r;
            }
            Console.Write("The number in reverse order is : {0} \n", sum);
        }
    }
}
