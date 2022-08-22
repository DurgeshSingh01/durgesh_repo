using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22th_hands_on
{
    internal class Problem4
    {
        static void Main(string[] args)
        {
            ArrayList arrlist = new ArrayList();
            arrlist.Add(1);
            arrlist.Add(2);
            arrlist.Add(3);
            arrlist.Add(4);
            arrlist.Add(5);
            arrlist.Add(1);
            Console.WriteLine("no of element in Arraylist before removing : "+ arrlist.Count);
            arrlist.Remove(1);
            arrlist.Remove(2);
            Console.WriteLine("no of element in Arraylist after removing : " + arrlist.Count);

        }
    }
}
