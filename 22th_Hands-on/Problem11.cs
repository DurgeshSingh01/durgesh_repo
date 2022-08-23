using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22th_hands_on
{
    internal class Problem11
    {
        static void Main(string[] args)
        {
            SortedList s1 = new SortedList();
            s1.Add(3, "Durgesh");
            s1.Add(2, "Archit");
            s1.Add(1, "Harshit");
            s1.Add(4, "Divya");
            foreach (DictionaryEntry item in s1)
            {
                Console.WriteLine(item.Key + "  " + item.Value);
            }
        }
    }
}
