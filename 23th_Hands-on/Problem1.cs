using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace _23th_Hands_on
{
    internal class Problem1
    {
        static void add(int i , int j)
        {
            int sum = i + j;
            Console.WriteLine("The sum of two integer given by the user: "+sum);
        }
        static void Main(string[] args)
        {
            Console.Write("Enter the first number: ");
            int i = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the second number: ");
            int j = Convert.ToInt32(Console.ReadLine());
            add(i,j);

        }
    }
}
