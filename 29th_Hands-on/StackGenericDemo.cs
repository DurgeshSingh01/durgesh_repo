using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29th_Hands_on
{
    internal class StackGenericDemo
    {
        static void Main(string[] args)
        {
            StackGeneric<String> stackGeneric = new StackGeneric<String>();
            stackGeneric.AddOrEdit(1, "Durgesh");
            stackGeneric.AddOrEdit(2, "Archit");
            stackGeneric.AddOrEdit(3, "Harshit");
            for (int i = 0; i <= 3; i++)
            {
                stackGeneric.ShowData(i);
            }

            Console.WriteLine("Integer stack");

            StackGeneric<int> intstack = new StackGeneric<int>();
            intstack.AddOrEdit(0, 10);
            intstack.AddOrEdit(1, 100);
            intstack.AddOrEdit(2, 1000);
            intstack.AddOrEdit(3, 10000);
            for (int i = 0; i <= 3; i++)
            {
                intstack.ShowData(i);
            }
            Console.ReadLine();

            
        }

        class StackGeneric<T>
        {
            T[] _data = new T[10];
            public void AddOrEdit(int index, T item)
            {

                if (index >= 0 && index <= 10)
                {
                    _data[index] = item;
                }
            }

            public T ReturnData(int index)
            {

                if (index >= 0 && index <= 10)
                {
                    return _data[index];
                }
                else
                {

                    return default(T);
                }


            }

            public void ShowData(int index)
            {

                Console.WriteLine(_data[index]);
            }

        }
    }
}
