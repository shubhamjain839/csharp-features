using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace all_in_one
{
    class dele
    {
        delegate void abc();
        public void print_hello()
        {
            Console.WriteLine("Hello");
        }
        public void print_bye()
        {
            Console.WriteLine("bye");
        }
        public void print_goodnight()
        {
            Console.WriteLine("goodnight");
        }
        public void print_goodmorning()
        {
            Console.WriteLine("goodmorning");
        }

        static void Main(string[] arg)
        {
            dele d1 = new dele();
            abc a1, a2, a3, a4;
            a1 = d1.print_hello;
            a2 = d1.print_bye;
            a3 = a1 + a2;
            a4 = a3 - a2;
            a1();
            a3();
            a4();

            Console.ReadKey();
        }
    }
}
