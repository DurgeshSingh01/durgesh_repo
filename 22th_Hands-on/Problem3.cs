using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22th_hands_on
{
    internal class Problem3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of the array");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            int s = 0;
            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter the {0} :", i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            
            for (int i = 0; i < arr.Length; i++)
            {
                s += arr[i];

            }
            Console.WriteLine("sum of the array : {0}",s);
            Console.ReadLine();

        }
    }
}
