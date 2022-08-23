using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22th_hands_on
{
    internal class Problem2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of the array");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter the {0} element of arr",i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Array.Reverse(arr);
            Console.WriteLine("now printing in reverse order");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("the element {0} : {1}", i, arr[i]);

            }
            Console.ReadLine();
        }
    }
}
