using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReusableCodeLibrary;
namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Class1.PrintString();
            Console.ReadLine();

            //1st Problem
            Console.Write("Enter first string: ");
            string str1 = Console.ReadLine();
            Console.Write("Enter second string: ");
            string str2 = Console.ReadLine();
            StringComparision.Compare(str1, str2);

            //2nd Problem
            Console.Write("Enter a string: ");
            string str3 = Console.ReadLine();
            CopyString.Copy(str3);

            //3rd Problem
            Console.Write("Enter a string: ");
            string str4 = Console.ReadLine();
            Console.Write("Enter a Character which index have to find : ");
            char ch = Convert.ToChar(Console.ReadLine());
            IndexOfChar.Index(str4, ch);

            //4th problem
            Console.Write("Enter the string :");
            string str5 = Console.ReadLine();
            SplitFile.Splite(str5);

            //5th Problem
            Console.Write("Enter the string :");
            string str6 = Console.ReadLine();
            UpperCase.Case(str6);

            //6th Problem
            CreateFile.FirstFile();

            //7th Problem
            DateTime dt = DateTime.Now;
            DayProperties.Date(dt);





        }
    }
}
