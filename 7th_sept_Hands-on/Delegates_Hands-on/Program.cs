using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using DelegatesHands_on;
using DelegatesLibrary;

namespace DelegatesHands_on
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Problem 1
            //GetStringLength();

            // Problem2
            //GreetingMsg();

            // Prohblem 3
            //MathsCombineOperation();

            // Problem 4
            //ShowingProduct();

            // Problem 5
            //EmployeeDetails();

            // Problem 6
            //Concatenation();

            Console.ReadLine();
        }

        private static void Concatenation()
        {
            Concatenation ct = new Concatenation();
            ConcatenatedStringdelegate dl = new ConcatenatedStringdelegate(ct.Concatenate);
            Console.Write("Enter the first string : ");
            string str1 = Console.ReadLine();
            Console.Write("Enter the second string : ");
            string str2 = Console.ReadLine();
            dl.Invoke(str1, str2);
        }

        private static void EmployeeDetails()
        {
            Employee employee = new Employee();
            joiningYeardelegate d1 = new joiningYeardelegate(employee.JoiningYear);
            joiningYeardelegate d2 = new joiningYeardelegate(employee.calculateYearsOfService);
            Console.Write("Enter the date of joining: ");
            DateTime dt = Convert.ToDateTime(Console.ReadLine());
            d1.Invoke(dt);
            d2.Invoke(dt);
        }

        private static void ShowingProduct()
        {
            Product p = new Product();
            ProductDelegateID Id = new ProductDelegateID(p.prodId);
            ProductDelegateName Name = new ProductDelegateName(p.prodName);
            Console.Write("Enter the id : ");
            int i = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the Product Name : ");
            string name = Convert.ToString(Console.ReadLine());
            Id.Invoke(i);
            Name.Invoke(name);
        }

        private static void MathsCombineOperation()
        {
            Maths m = new Maths();
            Console.WriteLine("Enter first Integer: ");
            int i = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second Integer: ");
            int j = Convert.ToInt32(Console.ReadLine());
            MathsOpr m1 = new MathsOpr(m.add);
            MathsOpr m2 = new MathsOpr(m.sub);
            MathsOpr m3 = new MathsOpr(m.multi);
            MathsOpr[] md = new MathsOpr[3] { m1, m2, m3 };
            MathsOpr mk = (MathsOpr)MulticastDelegate.Combine(md);
            mk.Invoke(i, j);
        }

        private static void GreetingMsg()
        {
            Geeting g = new Geeting();
            GreetDelegate gd = new GreetDelegate(g.GreetUser);
            Console.WriteLine("Enter Your Name: ");
            string user = Console.ReadLine();
            Console.WriteLine(gd.Invoke(user));
        }

        private static void GetStringLength()
        {
            StringLength sl = new StringLength();
            StringLenghtDelegate sld = new StringLenghtDelegate(sl.len);
            Console.WriteLine("Enter the string : ");
            string k = Console.ReadLine();
            int i = sld.Invoke(k);
            Console.WriteLine("Length of the string : " + i);
            
        }
    }
}
