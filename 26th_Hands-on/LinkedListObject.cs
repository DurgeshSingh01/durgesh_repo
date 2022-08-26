using HRLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26th_Hands_on
{
    internal class LinkedListObject
    {
        static void Main(string[] args)
        {
            LinkedList<Students.Student> std = new LinkedList<Students.Student>();
            std.AddFirst(new Students.Student() { Rollno = 101, StudentName = "Durgesh", BranchName = "Electrical" });
            std.AddLast(new Students.Student() { Rollno = 104, StudentName = "Aditya", BranchName = "Electrical" });
            std.AddAfter(std.First, new Students.Student() { Rollno = 102, StudentName = "Archit", BranchName = "Electrical" });
            std.AddBefore(std.Last, new Students.Student() { Rollno = 103, StudentName = "Divya", BranchName = "Electrical" });
            foreach (var item in std)
            {
                Console.WriteLine();
                Console.WriteLine("Now priniting details of {0}",item.StudentName);
                Console.WriteLine(item.Rollno);
                Console.WriteLine(item.StudentName);
                Console.WriteLine(item.BranchName);
            }
            Console.ReadLine();

        }
    }
}
