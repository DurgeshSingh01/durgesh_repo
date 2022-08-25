using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace _25th_Hand_on
{
    internal class Problem4
    {
        static void Main(string[] args)
        {
            Console.WriteLine("C drive info");
            DriveInfo info = new DriveInfo("C");
            Console.WriteLine(info.Name);
            Console.WriteLine(info.TotalSize);
            Console.WriteLine(info.DriveType);
            Console.WriteLine(info.DriveFormat);
            Console.WriteLine();
            Console.WriteLine("==================================================");
            Console.WriteLine("All drives' name");
            DriveInfo[] dinfo = DriveInfo.GetDrives();
            foreach (var item in dinfo)
            {
                Console.WriteLine(item.Name);
            }
            Console.ReadLine();
        }
    }
}
