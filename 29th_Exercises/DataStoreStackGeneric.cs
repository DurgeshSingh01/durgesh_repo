using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29th_practice
{
    internal class DataStoreStackGeneric
    {
        static void Main(string[] args)
        {
            //UserdataStores<string> stringdata = new UserdataStores<string>();
            //stringdata.AddOrEdit(0, "Hello");
            //string printdata = stringdata.ReturnData(0);
            //Console.WriteLine(printdata);
            //Console.WriteLine("-------------------");
            //stringdata.AddOrEdit(0, "Welcome");

            //stringdata.ShowData(0);
            UserdataStores<int> store = new UserdataStores<int>();
            store.AddOrEdit(0, 5);
            store.AddOrEdit(1, 15);
            int n = store.ReturnData(0);
            Console.WriteLine(n);
            int m = store.ReturnData(1);
            Console.WriteLine(n);
            store.ShowData(1);


            Console.ReadLine();
        }
    }
}
