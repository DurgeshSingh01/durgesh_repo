using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23th_Hands_on
{
    internal class Problem2
    {
        static int add(int i, int j)
        {
            int sum = i + j;
            return sum;
        }
        static void Main(string[] args)
        {
            Console.Write("Enter the first number: ");
            int i = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the second number: ");
            int j = Convert.ToInt32(Console.ReadLine());
            int sum = add(i, j);
            Console.WriteLine("The sum of two integer given by the user: " + sum);
        }
    }
}
