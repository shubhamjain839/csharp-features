using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace all_in_one
{
    class boxingUn
    {
        static void Main(string[] args)
        {
            int a = 200;
            object obj = new object();
            obj = a;
            Console.WriteLine("value of a is "+a);
            a = 300;
            Console.WriteLine("value of a after change is " + a);
            Console.WriteLine("value of obj is " + obj);
            int b = (int)obj;
            Console.WriteLine("value of b is " + b);
            Console.ReadKey();
        }
    }
}
