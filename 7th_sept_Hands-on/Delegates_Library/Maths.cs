using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesLibrary
{
    public delegate void MathsOpr(int i, int j);
    public class Maths
    {
        public void add(int i, int j)
        {
            int ans = i+ j;
            Console.WriteLine("The sum : "+ans);
        }
        public void sub(int i , int j)
        {
            int ans = i - j;
            Console.WriteLine("The substraction : " + ans);
        }
        public void multi(int i, int j)
        {
            int ans = i * j;
            Console.WriteLine("The multiplication : " + ans);
        }
    }
}
