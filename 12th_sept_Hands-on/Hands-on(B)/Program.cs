using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CustomAttribute
{
    internal class Program
    {
        static void GetCustomAttr(Type t)
        {
            Console.WriteLine("Class name: " + t.FullName);

            //Reflection

            Attribute[] Attrs = System.Attribute.GetCustomAttributes(t);

            //print custom attr of class 


            foreach (var attr in Attrs)
            {
                Console.WriteLine("-----Custom attr of CLASS SONGS-------------");

                if (attr is Disc)
                {
                    Disc s = (Disc)attr;
                    Console.WriteLine(s.SongName);
                    Console.WriteLine(s.Language);
                    Console.WriteLine(s.Lyrics);
                    
                }
                Console.WriteLine("------------------");

            }

            MemberInfo[] mi = t.GetMembers();

            foreach (var item in mi) // for traversing each members of class
            {
                Console.WriteLine(item.Name);
                System.Attribute[] attr1 = System.Attribute.GetCustomAttributes(item);
                foreach (System.Attribute attritem in attr1) //for attributes of each members
                {
                    if (attritem is Disc)
                    {
                        Console.WriteLine("---------");
                        Disc s1 = (Disc)attritem;

                        Console.WriteLine(s1.SongName);
                        Console.WriteLine(s1.Language);
                        Console.WriteLine(s1.Lyrics);
                    }
                }

                Console.WriteLine("----END OF A MEMBER-----");


            }

        }
        static void Main(string[] args)
        {

            Program.GetCustomAttr(typeof(Song));

            Console.Read();
        }
    }
}
