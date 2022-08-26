using HRLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26th_Hands_on
{
    internal class ListDemo
    {
        static void Main(string[] args)
        {
            List<Students.Student> studentlist = new List<Students.Student>();
            studentlist.Add(new Students.Student() { Rollno=105,StudentName="Durgesh",BranchName="Electricl"});
            studentlist.Add(new Students.Student() { Rollno = 106, StudentName = "Archit", BranchName = "Electricl" });
            studentlist.Add(new Students.Student() { Rollno = 105, StudentName = "Harshit", BranchName = "Electricl" });
            Console.WriteLine("Before Removing...");
            foreach (var item in studentlist)
            {
                Console.WriteLine();
                Console.WriteLine("Now printing....");
                Console.WriteLine(item.Rollno);
                Console.WriteLine(item.StudentName);
                Console.WriteLine(item.BranchName);
            }
            studentlist.Remove(new Students.Student() { Rollno = 105, StudentName = "Harshit", BranchName = "Electricl" });
            Console.WriteLine("=======================================");
            Console.WriteLine("After Removing...");
            foreach (var item in studentlist)
            {
                Console.WriteLine();
                Console.WriteLine("Now printing....");
                Console.WriteLine(item.Rollno);
                Console.WriteLine(item.StudentName);
                Console.WriteLine(item.BranchName);
            }
            Console.ReadLine();
        }
    }
}
