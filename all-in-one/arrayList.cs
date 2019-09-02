using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace all_in_one
{
    class arrayList
    {
        static void Main(string[] arg)
        {
            ArrayList ar = new ArrayList();
            ar.Add("hello");
            ar.Add("My Name Is ");
            ar.Add("Shubham Jain");
            ar.Add("Age is :");
            ar.Add(22);
            ar.Add("Bye");
            for(int i = 0; i < ar.Count; i++)
            {
                Console.WriteLine(ar[i]);
            }
            Console.WriteLine("Capacity of ArrayList is : {0}", ar.Capacity);
            Console.WriteLine("Element Count of ArrayList is : {0}", ar.Count);
            Console.WriteLine("Occurenece of 'Shubham Jain' in ArrayList is at : {0}", ar.IndexOf("Shubham Jain")+1);
            Console.WriteLine("Removed element at index : 0");
            ar.RemoveAt(0);
            for (int i = 0; i < ar.Count; i++)
            {
                Console.WriteLine(ar[i]);
            }
            Console.ReadKey();
        }
    }
}
