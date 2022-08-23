using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19th_handson
{
    internal class problem13
    {
        static void Main()
        {
            int i;
            Console.Write("Enter an Number: ");
            i = Convert.ToInt32(Console.ReadLine());
            if (i == 0)
                Console.WriteLine("The given is zero");
            else if (i > 100)
                Console.WriteLine("the given nuber is too large");
            else if (i % 10 == 0)
                Console.WriteLine("Given number is multiple of 10");
            else if (i % 2 == 0)
                Console.WriteLine("The given number is even");
            else if (i % 2 != 0)
                Console.WriteLine("Given number is odd");
            
            Console.ReadLine();
        }
    }
}
