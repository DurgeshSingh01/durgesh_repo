using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRLibrary;
namespace DataStructureFirstday
{
    internal class LinkedListdemo
    {
        static void Main(string[] args)
        {
            LinkedList<Employee> emp = new LinkedList<Employee>();
            emp.AddFirst(new Employee { EmpID = 15, EmpName = "Jack", DeptNo = 104, City = "Pune" });
            emp.AddLast(new Employee { EmpID = 20, EmpName = "Jimm", DeptNo = 108, City = "Pune" });
            emp.AddAfter(emp.First,new Employee { EmpID = 16, EmpName = "jill", DeptNo = 105, City = "Pune" });
            emp.AddBefore(emp.Last, new Employee { EmpID = 19, EmpName = "Hari", DeptNo = 107, City = "Pune" });
            Employee empf = emp.ElementAt(1);
            emp.AddAfter(emp.Find(empf), new Employee { EmpID = 17, EmpName = "pari", DeptNo = 106, City = "Pune" });
            foreach (Employee e in emp)
            {
                Console.WriteLine();
                Console.WriteLine("Now Printing details of {0}",e.EmpName);
                Console.WriteLine(e.EmpID);
                Console.WriteLine(e.EmpName);
                Console.WriteLine(e.DeptNo);
                Console.WriteLine(e.City);

            }
            Console.ReadLine();
        }
    }
}
