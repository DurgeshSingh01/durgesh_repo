using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data.SqlTypes;

namespace _25th_Hand_on
{
    internal class Problem1
    {
        static void Main(string[] args)
        {
            
            
            Console.WriteLine("For Create a file press 1:");
            Console.WriteLine("For write the file press 2:");
            Console.WriteLine("For read something press 3:");
            Console.WriteLine("for trucate press 4: ");
            int i = Convert.ToInt32(Console.ReadLine());
            switch (i)
            {
                case 1:
                    Console.WriteLine("Enter the file you want to create : ");
                    string txt = Console.ReadLine();
                    FileStream fs = new FileStream(txt, mode: FileMode.OpenOrCreate, FileAccess.ReadWrite);
                    fs.Close();
                    fs.Dispose();
                    break;

                case 2:
                    Console.Write("File name : ");
                    string str1 = Console.ReadLine();
                    Console.Write("Enter the text to add: ");
                    string str = Console.ReadLine();
                    StreamWriter sw = new StreamWriter(str1);
                    sw.WriteLine(str);
                    sw.Flush();
                    sw.Close();
                    sw.Dispose();
                    break;
                case 3:
                    Console.Write("File name : ");
                    string str2 = Console.ReadLine();
                    StreamReader sr = new StreamReader(str2);
                    string content = sr.ReadToEnd();
                    Console.Write(content);
                    sr.Close();
                    sr.Dispose();
                    break;
                case 4:
                    Console.WriteLine("Enter the file name to truncate...");
                    string str3 = Console.ReadLine();
                    FileStream ts = new FileStream(str3, FileMode.Truncate, FileAccess.Write);
                    Console.WriteLine("Truncated");
                    ts.Close();
                    ts.Dispose();
                    break;
            }
            Console.ReadLine();



            
        }
    }
}
