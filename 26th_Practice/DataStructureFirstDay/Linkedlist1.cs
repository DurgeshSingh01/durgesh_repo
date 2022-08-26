using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureFirstday
{
    internal class Linkedlist1
    {
        static void Main(string[] args)
        {
            LinkedList<string> mylist = new LinkedList<string>();
            mylist.AddFirst("Durgesh");
            mylist.AddLast("Aditya");
            mylist.AddAfter(mylist.First, "Archit");
            mylist.AddBefore(mylist.Last, "Harshit");
            LinkedListNode<string> node = mylist.Find("Harshit");
            node.Value = "Divya";
            foreach (var item in mylist)
            {
                Console.WriteLine(item);

            }
            Console.ReadKey();
        }
    }
}
