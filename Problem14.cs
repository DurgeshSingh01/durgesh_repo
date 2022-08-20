using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19th_handson
{
    internal class Problem14
    {
        static void Main()
        {
            int i;
            Console.WriteLine("Enter a number : ");
            i = Convert.ToInt32(Console.ReadLine());
            switch (i%2)
            {
                case 0: Console.WriteLine("the number is odd");
                    break;
                case 1: Console.WriteLine("The number is odd");
                    break;
                default: Console.WriteLine("the number is zero");
                    break;
            }
            Console.ReadLine();


        }
    }
}
