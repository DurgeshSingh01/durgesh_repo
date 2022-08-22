using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Arraydemo
{
    internal class Jagged
    {
        static void Main(string[] args)
        {
            int[][] jagged_arr = new int[][]
            {
                new int[] { 1,2,3,4} ,
                new int[] {11,12,15},
                new int[] { 89,90 },
                new int[] { 2,100,55,78,90}

            };

            int[][] jagged_second ={
                new int[] { 1,2,3,4} ,
                new int[] {11,12,15},
                new int[] { 89,90 },
                new int[] { 2,100,55,78,90}

            };

            int[][] jarr = new int[4][];
            jarr[0] = new int[]{1,2,3,4};
            jarr[1] = new int[]{5,6,7,8};
            jarr[2] = new int[]{9,10,11,12};
            jarr[3] = new int[]{11,12,13,14};
            Console.WriteLine("------Using For loop------");
            for (int i = 0; i < jarr.Length; i++)
            {
                Console.WriteLine("Row ({0}) ",i +"\t");
                for (int j = 0; j < jarr[i].Length; j++)
                {
                    Console.Write(jarr[i][j] + "\t " );

                }
                Console.WriteLine();
                

            }
            Console.ReadLine();

        }
    }
}
