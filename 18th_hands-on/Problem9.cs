using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_handson
{
    internal class Problem9
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter temperature in celsius: ");
            int celsius = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Kelvin = {0}", celsius + 273);
            Console.WriteLine("Fahrenheit = {0}", celsius* 18 / 10 + 32);
        }
    }
}
