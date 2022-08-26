using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRLibrary;
namespace _26th_Hands_on
{
    internal class ArrayStudentObject
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of students: ");
            int n = Convert.ToInt32(Console.ReadLine());
            
            Students.Student[] std = new Students.Student[n];
            for(int i = 0; i < n; i++)
            {
                std[i] = new Students.Student();
                Console.WriteLine("Enter the roll no : ");
                std[i].Rollno = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the student name : ");
                std[i].StudentName = Console.ReadLine();
                Console.WriteLine("Enter the branch of the student :");
                std[i].BranchName = Console.ReadLine();
            }

            foreach (var item in std)
            {
                Console.WriteLine();
                Console.WriteLine("Now pronting the student details...");
                Console.WriteLine(item.Rollno);
                Console.WriteLine(item.StudentName);
                Console.WriteLine(item.BranchName);

            }
            Console.ReadLine();
            
        }
        
    }
}
