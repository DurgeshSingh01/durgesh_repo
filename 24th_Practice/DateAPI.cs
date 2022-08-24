using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    internal class DateAPI
    {
        static void Main(string[] args)
        {
            DateTime dt = DateTime.Now;
            DateTime dob = new DateTime();
            
            Console.Write("Enter your date of birth : ");
            dob = Convert.ToDateTime(Console.ReadLine());
            TimeSpan age = dt.Subtract(dob);

            Console.WriteLine("Your age in Years : {0}",dt.Year-dob.Year);
            Console.WriteLine("Your age in months : {0}, ", dt.Month - dob.Month);
            Console.WriteLine("Is birthyear leapyear: {0}",DateTime.IsLeapYear(dob.Year));
            Console.WriteLine("day of the week : {0}", dob.DayOfWeek);
        }
    }
}
