using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRLibrary;
namespace DataStructureFirstday
{
    internal class ObjectListDemo
    {
        static void Main(string[] args)
        {
            List<Employee> emplist = new List<Employee>();
            emplist.Add(new Employee { EmpID=14,EmpName="Divya",DeptNo=102,City="Mumbai"});

            Employee emp1 = new Employee();
            emp1.EmpID = 14;
            emp1.EmpName = "Aditya";
            emp1.DeptNo = 104;
            emp1.City = "Bangalore";
            emp1.CalculateSalary(100000);
            Console.WriteLine("Gross salary: {0}",emp1.GrossSalary);
            emplist.Add(emp1);
            foreach (Employee emp in emplist)
            {
                Console.WriteLine(emp.EmpID);
                Console.WriteLine(emp.EmpName);
                Console.WriteLine(emp.DeptNo);
                Console.WriteLine(emp.City);
            }
            Console.ReadLine();
        }
    }
}
