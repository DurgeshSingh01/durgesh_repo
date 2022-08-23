using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_handson
{
    public static class Problem15
    {
        static void Main()
        {
            Console.WriteLine("enter in dollor: ");
            int dollor = Int32.Parse(Console.ReadLine());
            int rup = dollor * 80;
            Console.WriteLine("in rupees :{rup}", rup);
            Console.WriteLine();
        }
    }
}
