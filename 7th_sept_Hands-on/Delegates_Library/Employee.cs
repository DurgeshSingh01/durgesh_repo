using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesLibrary
{
    public delegate void joiningYeardelegate(DateTime dt);
    public delegate void calculateYearsOfServicedelegate(DateTime dt1);
    public delegate void ConcatenatedStringdelegate(string s1, string s2);
    public class Employee
    {
        public void  JoiningYear(DateTime dt)
        {
            Console.WriteLine("Your Joining Year : {0}", dt.Year);

        }

        public void calculateYearsOfService(DateTime dt)
        {
            DateTime dt1 = DateTime.Now;
            TimeSpan t = dt1 - dt;
            int k = Convert.ToInt32(t.TotalDays);
            Console.WriteLine("Total No of days You have worked: {0}",k);
        }
    }

    public class Concatenation
    {
        public void Concatenate(string s1, string s2)
        {
            Console.WriteLine("Concatenated String- {0}", s1+ s2);   
        }
    }
}
