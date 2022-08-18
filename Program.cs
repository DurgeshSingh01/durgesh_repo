using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2nd_day_demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i;
            float radius;
            float pi = 3.14f;
            Console.WriteLine("enter radius");
            radius = Convert.ToSingle(Console.ReadLine());

            double area = pi * radius * radius;
            
            Console.WriteLine(area);
            Console.WriteLine();
        }
    }
}
