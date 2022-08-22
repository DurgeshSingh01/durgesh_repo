using System;
using System.Collections;


namespace Arraydemo
{
    internal class NonGenericDemo
    {
        static void Main(string[] args)
        {
            Stack s = new Stack();
            s.Push(1);
            s.Push(2);
            s.Push(3);
            s.Push(4);
            s.Push(5);
            s.Pop();//5
            s.Contains(1);//true
            
            object ob = s.Peek();
            Console.WriteLine(ob);

            object a1 = s.Pop();//true
            Console.WriteLine(a1);
            a1 = s.Pop();//A
            Console.WriteLine(a1);
            a1 = s.Pop();//Hello
            Console.WriteLine(a1);
            object p = s.Peek();//returns datetime
            Console.WriteLine(p);

            int cnt = s.Count;
            bool ans = s.Contains(134);
            Console.WriteLine("Is 134 available on the stack= " + ans);
            object[] obj = s.ToArray();
            foreach (var item in obj)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("----------------------");
            Queue q = new Queue(10, 2);//FIFO--First in first out
            q.Enqueue(45);
            q.Enqueue(4567.45f);
            q.Enqueue(33);
            //object a2=q.Dequeue();//45
            //Console.WriteLine(a2);

            q.Peek();
            Console.WriteLine("Before trimming=" + q.Count);
            q.TrimToSize();
            Console.WriteLine("After trimming");
            Console.WriteLine(q.Count);
            Console.WriteLine("Q elements are ");
            foreach (var item in q)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("----------Hash table----------------");
            Hashtable h = new Hashtable();
            h.Add(1, "tea");
            h.Add(2, "Coffee");
            h.Add(3, "Coke");
            h.Add(4, "Milk");
            h.Add(5, "thumsup");
            IDictionaryEnumerator ie = h.GetEnumerator();
            while (ie.MoveNext())
            {
                Console.WriteLine(ie.Key + "  " + ie.Value);
            }
            Console.WriteLine("Using for each");
            foreach (DictionaryEntry item in h)
            {
                Console.WriteLine(item.Key + "  " + item.Value);

            }
            Console.WriteLine("---------");

            ArrayList al = new ArrayList();
            al.Add(34);

            al.Add(445);
            al.Add("Hello");
            al.Add(34);
            al.Add(34535);
            al.Add(444);
            al.Add(1111);
            al.Remove(34);//first occurence of 34 in the arraylist
            al.RemoveAt(0);//445
            al.RemoveRange(0, 2);
            al.Sort();
            al.Reverse();

            SortedList s1 = new SortedList();
            s1.Add(3, 56);
            s1.Add(30, 89);
            s1.Add(13, 6777);
            foreach (DictionaryEntry item in s1)
            {
                Console.WriteLine(item.Key + "  " + item.Value);
            }
        }
    }
}
