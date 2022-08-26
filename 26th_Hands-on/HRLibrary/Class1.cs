using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRLibrary
{
    public class Students
    {
        static void Main(string[] args)
        {

        }
        public struct Student
        {
            public int _rollno;
            public int Rollno
            {
                get
                {

                    return _rollno;
                }
                set
                {
                    _rollno = value;

                }
            }

            public string _studname;
            public string StudentName
            {
                set
                {
                    _studname = value;
                }
                get
                {

                    return _studname;

                }

            }

            public string _branchname;

            public string BranchName
            {
                get { return _branchname; }
                set { _branchname = value; }
            }


        }
    }
}
