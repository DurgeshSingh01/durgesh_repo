using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29th_practice
{
    internal class BinarySearch
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the size of the array: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] intarr = new int[n];
            string[] str =  Console.ReadLine().Split(' ');
            for(int i = 0; i < n; i++)
            {
                intarr[i] = int.Parse(str[i]);
            }
            Array.Sort(intarr);
            Console.WriteLine("Enter the number to be search: ");
            int f = Convert.ToInt32(Console.ReadLine());
            DoBinarySearch(intarr ,f);
            Console.ReadLine();
        }

        public static void DoBinarySearch(int[] arr, int f)
        {
            int minNum = 0;
            int maxNum = arr.Length - 1;

            while (minNum <= maxNum)
            {
                int mid = (minNum + maxNum) / 2;
                if (f == arr[mid])
                {
                    Console.WriteLine("Founded at:{0}", mid);
                    break;
                }
                else if (f < arr[mid])
                {
                    maxNum = mid - 1;
                }
                else
                {
                    minNum = mid + 1;
                }
            }
        }
    }
}
