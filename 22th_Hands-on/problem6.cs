using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22th_hands_on
{
    internal class problem6
    {
        static void Main(string[] args)
        {
            Stack s = new Stack(2);
            s.Push(1);
            s.Push(2);
            s.Push(3);
            s.Push("Durgesh");
            s.Push("Singh");
            Console.WriteLine("Peek value");
            object t = s.Peek();
            Console.WriteLine(t);
            int cnt = s.Count;
            Console.WriteLine("Bofore popping the size of stack");
            Console.WriteLine(cnt);
            object i = s.Pop();
            Console.WriteLine("Popped value:");
            Console.WriteLine(i);
            int cnt2 = s.Count;
            Console.WriteLine("After perfome popping the size of stack");
            Console.WriteLine(cnt2);
        }
    }
}
