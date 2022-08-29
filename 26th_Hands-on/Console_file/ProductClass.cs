using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRLibrary;
namespace _26th_Hands_on
{
    internal class ProductClass
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();
            products.Add(new Product() { Namme="Pencil"});
            products.Add(new Product() { Namme = "Pen" });
            products.Add(new Product() { Namme = "Eraser" });
            products.Add(new Product() { Namme = "Scale" });
            Console.WriteLine("============================");
            Console.WriteLine("Before Removing");
            foreach (var p in products)
            {
                Console.WriteLine(p.Namme);

            }
            Console.WriteLine("============================");
            Console.WriteLine("After Removing");
            products.Remove(new Product() { Namme = "Pen" });
            foreach (var k in products)
            {
                Console.WriteLine(k.Namme);

            }
            Console.ReadLine();


        }
    }
}
