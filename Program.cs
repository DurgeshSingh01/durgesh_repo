using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arraydemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[5] { 1, 2, 3, 4, 5 };
            int[] arr2 = new int[] { 100, 200, 300 };
            for (int i = 0; i < arr1.Length; i++)
            {
                Console.WriteLine(arr1[i]);

            }
            for (int i = 0; i < arr2.Length; i++)
            {
                Console.WriteLine(arr2[i]); 
            }
            Console.WriteLine("---------using the foreach loop---------");
            foreach(var i in arr1)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("---------using the float array---------");
            float[] areas = new float[] { 1.4f, 1.2f, 1.6f, 15.8f };
            foreach (var i in areas)
            {
                Console.WriteLine(i);
            }

            //Console.WriteLine("------taking Array input from console.-------");
            //int[] areas2 = new int[5];
            //for (int i = 0; i < areas2.Length; i++)
            //{
            //    Console.WriteLine("Enter the array element a[{0}]",i);
            //    areas2[i] = Convert.ToInt32(Console.ReadLine());


            //}
            //Console.WriteLine("Now printing");
            //foreach (var item in areas2)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine("-------creat array using instance -----------");
            //Array arr4= Array.CreateInstance(typeof(int), 5);
            //Console.ReadLine();

            Console.WriteLine("-----after sort-------");
            int[] price = new int[] { 10, 22, 13, 33, 45, 16, 77, 88, 84 };
            Array.Sort(price);
            foreach (var it2 in price)
            {
                Console.WriteLine(it2);
            }
            int[] price_copied = new int[price.Length];
            Array.Copy(price, price_copied, price.Length);
            Console.WriteLine("-----copied array-------");
            foreach (var it3 in price_copied)
            {
                Console.WriteLine(it3);
            }


        }
    }
}
