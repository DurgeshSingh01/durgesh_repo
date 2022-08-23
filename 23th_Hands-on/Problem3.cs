using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23th_Hands_on
{
    internal class Problem3
    {
        struct Employees
        {
            public int empno;
            public string ename;
            public int sal;
            public int deptno;
        };

      
            public static void Main(string[] args)
            {
                Employees emp1;
                Employees emp2;

                emp1.empno = 07;
                emp1.ename = "Durgesh";
                emp1.sal = 400000;
                emp1.deptno = 801;

                emp2.empno = 18;
                emp2.ename = "Archit";
                emp2.sal = 550000;
                emp2.deptno = 97;

                Console.WriteLine(" ---- Printing First Employee details");
                Console.WriteLine("Employee 1 Number : {0}", emp1.empno);
                Console.WriteLine("Employee 1 Name : {0}", emp1.ename);
                Console.WriteLine("Employee 1 Salary : {0}", emp1.sal);
                Console.WriteLine("Employee 1 Department Number : {0}", emp1.deptno);
                Console.WriteLine();
                Console.WriteLine(" ---- Printing Second Employee details");
                Console.WriteLine("Employee 2 Number : {0}", emp2.empno);
                Console.WriteLine("Employee 2 Name : {0}", emp2.ename);
                Console.WriteLine("Employee 2 Salary : {0}", emp2.sal);
                Console.WriteLine("Employee 2 Department Number : {0}", emp2.deptno);

                Console.ReadKey();
            }
        }

    }