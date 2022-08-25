using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25th_Hand_on
{
    internal class Problem2
    {
        static void Main(string[] args)
        {
            string path = @"D:\Mphasis\c#_exercise\25_demo\fileProgram-problem2\";
            Console.WriteLine("Enter the file name");
            string fname = Console.ReadLine();
            fname = string.Concat(path, fname);

            // Statemnet a
            //File.Create(fname);
            //File.WriteAllText(fname, "Hello, I am learning C# & .net");
            //Console.WriteLine($"{fname} File Created...");

            //Statement b and c
            //fname = string.Concat(fname,"\\");
            //File.Copy(fname, "copied.txt");
            //File.Move(fname, "movedfile.txt");

            // Checking file existance
            bool fileExists = File.Exists(fname);
            Console.WriteLine("File Exists=  " + fileExists);

            //Delete file
            File.Delete(fname);

            
            

            // Directory of the file-- problem statement g
            FileInfo fi = new FileInfo(fname);
            string str = fi.DirectoryName;
            Console.WriteLine($"{str} is directory name...");

            // problem statement f -- creation time of the file..
            DateTime dt = new DateTime();
            dt = fi.CreationTime;
            Console.WriteLine($"Creation time of the file : {dt}");






        }
    }
}
