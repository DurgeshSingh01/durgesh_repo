using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23th_Hands_on
{
    internal class Problem4_
    {
        struct Employee
        {
            int Empno;
            string Empname;
            int Salary;
            int Deptno;






            public Employee(int Empno, string _empname, int _salary, int _deptno)
            {

                this.Empno = Empno;
                Empname = _empname;
                Salary = _salary;
                Deptno = _deptno;

            }

            public void AcceptBookData(int empno, string empname, int salary, int deptno)
            {
                Empno = empno;
                Empname = empname;
                Salary = salary;
                Deptno = deptno;


            }

            public void DisplayInfo()
            {
                Console.WriteLine();
                Console.WriteLine("Now Printing the details...");
                Console.WriteLine(Empno);
                Console.WriteLine(Empname);
                Console.WriteLine(Salary);
                Console.WriteLine(Deptno);

            }
            static void Main(string[] args)
            {

                Employee emp1 = new Employee();

                Console.WriteLine("Enter the employee id: ");
                int empid = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter the employee Name : ");
                string empname = Console.ReadLine();

                Console.WriteLine("Enter the employee Salary : ");
                int salary = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter the employee department number: ");
                int deptid = Convert.ToInt32(Console.ReadLine());



                emp1.AcceptBookData(empid, empname, salary, deptid);
                Console.WriteLine("Now Printing the data");
                emp1.DisplayInfo();
                Console.ReadLine();
            }

        }
    }
}
