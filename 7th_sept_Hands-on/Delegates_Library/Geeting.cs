using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesLibrary
{
    public delegate string GreetDelegate(string Name);
    public class Geeting
    {
        
        public string GreetUser(string Name)
        {
            string greetmsg = "Hello " + Name + " , Welcome in my world!";
            return greetmsg;
        }
    }
}
