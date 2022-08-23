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
            int number1, number2;
            Console.Write("Input the First Number : ");
            number1 = int.Parse(Console.ReadLine());
            Console.Write("Input the Second Number : ");
            number2 = int.Parse(Console.ReadLine());
            callbyvalue(number1,number2);
        }
        static void callbyvalue(int x, int y)
        {
            int z;
            z = x;
            x = y;
            y = z;
            Console.WriteLine("---After swaping through callbyvalue---");
            Console.WriteLine("First Number : " + x);
            Console.WriteLine("Second Number : " + y);
        }

        

    }
}
