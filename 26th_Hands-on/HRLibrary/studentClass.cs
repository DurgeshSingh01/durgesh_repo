using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace HRLibrary
{
    public class studentClass
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
