using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _29th_practice
{
    internal class LinearSearch
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] {1,2,3,4,5,6,7,8,9,10};
            Console.Write("Enter the number to be search: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int cnt = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == n)
                {
                    Console.WriteLine("Founded at index {0}",i);
                    cnt += 1;
                    break;
                }
                
            }
            if (cnt == 0)
                Console.WriteLine("Not Founded");
            Console.ReadLine();
        }
    }
}
