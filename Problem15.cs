using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _22th_hands_on
{
    internal class Problem15
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter the size of array: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] intArray = new int[n];
            var stringArray = Console.ReadLine().Split(' ');
            for (var i = 0; i < n; i++)
            {
                intArray[i] = int.Parse(stringArray[i]);
            }
            foreach(int j in intArray)
            {
                int cnt = 0;
                for (int i = 0; i < intArray.Length; i++)
                {
                    if (j == intArray[i])
                    {
                        cnt++;
                    }
                    
                }
                if (cnt > 1)
                {
                    Console.WriteLine("The first repeated value occured at index: {0}", Array.IndexOf(intArray, j));
                    break;
                }
            }
            Console.ReadLine();
        }
    }
}
