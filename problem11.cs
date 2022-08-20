using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19th_handson
{
    internal class problem11
    {
        static void Main()
        {
            int i, sum=0;
            for (i = 101; i < 200; i++)
            {
                sum += i;
            }
            Console.WriteLine(sum);
            Console.ReadLine();
        }
    }
}
