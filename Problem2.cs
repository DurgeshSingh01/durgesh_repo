using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19th_handson
{
    internal class Problem2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter third number");
            int num3 = Convert.ToInt32(Console.ReadLine());
            if (num1 > num2)
            {
                if (num1 > num3)
                {
                    Console.WriteLine("Number one is the largest!");
                    Console.WriteLine("Number third is the lowest!\n");
                }
                else
                {
                    Console.Write("Number three is the largest!\n");
                    Console.Write("Number two is the lowest!\n");
                }
            }
            else if (num2 > num3) { 
                Console.Write("Number two is the largest!\n");
                Console.Write("Number three is the lowest!\n");
            }
            else { 
                Console.Write("Number three is the largest!\n");
                Console.Write("Number one is the lowest!\n");
            }
            Console.ReadLine();
        }



    }
}