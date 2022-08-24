using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReusableCodeLibrary
{
    public class CreateFile
    {
        public static void FirstFile()
        {
            string path = @"D:\Mphasis\c#_exercise\MyApp\FirstFile.txt";
            File.Create(path);
        }
    }
}
