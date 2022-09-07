using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRLibrary
{
    public abstract class Person
    {
        public abstract void Work();
    }

    public class Manager : Person

    {
        public override void Work()
        {
            Console.WriteLine(" Calling Manager");
        }
    }

    public class Employee : Person

    {
        public override void Work()
        {
            Console.WriteLine("Calling Employee");
        }
    }

    public class Clerk : Person

    {
        public override void Work()
        {
            Console.WriteLine("Calling Clerk");
        }
    }



}
