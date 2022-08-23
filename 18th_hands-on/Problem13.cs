using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_handson
{
    internal class Problem13
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter distance in meter: ");
            int mtr = Int32.Parse(Console.ReadLine());
            Console.WriteLine("enter distance in kilometer: ");
            int km = Int32.Parse(Console.ReadLine());

            double kilometer = mtr / 1000;
            int meter = km * 1000;
            Console.WriteLine("The distance in kilometer = {0} km", kilometer);
            Console.WriteLine("The distance in meter = {0} m", meter);
        }
    }
}
