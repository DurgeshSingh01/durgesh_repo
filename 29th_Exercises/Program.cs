using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29th_practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UserStack s = new UserStack();
            Console.WriteLine("IEmpty= " + s.isStackEmpty());
            Console.WriteLine("------------");
            s.Push(10);
            s.Push(100);
            s.Push(20);
            s.Push(40);
            Console.WriteLine("Pop ");
            s.Pop();
            Console.WriteLine("---------------------");
            Console.WriteLine("Peek");
            s.Peek();
            Console.WriteLine("---------------------");
            s.PrintStackElements();
            Console.WriteLine("IEmpty= " + s.isStackEmpty());
            Console.ReadLine();
        }
    }
}
