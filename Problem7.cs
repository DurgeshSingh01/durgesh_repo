using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19th_handson
{
    internal class Problem7
    {
        static void Main(string[] args)
        {
            int i, j, k, total, percentage;
            Console.WriteLine("Enter the number of first subject: ");
            i = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the number of second subject: ");
            j = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the number of third subject: ");
            k = Convert.ToInt32(Console.ReadLine());
            total = i + j + k;
            percentage = (total * 100) / 300;
            Console.WriteLine($"Total number of student = {total}");
            Console.WriteLine($"Percentge: {percentage} %");
            if (percentage < 35)
                Console.WriteLine("failed");
            else if (percentage > 35 && percentage < 45)
                Console.WriteLine("Third division");
            else if (percentage > 45 && percentage < 60)
                Console.WriteLine("Second division");
            else if (percentage > 60)
                Console.WriteLine("First division");
            Console.ReadLine();
        }
    }
}
