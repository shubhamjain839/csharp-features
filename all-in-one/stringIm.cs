using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace all_in_one
{
    class stringIm
    {
        static void Main(string[] arg)
        {
            
            string a = "Hello! World";
            string b = "Have A Nice Day";
            object[] ar = { "hello","bye","hi"};
            Console.WriteLine(a);
            Console.WriteLine(b);
            if (string.Compare(a, b) != 0)
            {
                Console.WriteLine("Strings are not equal! ");
            }
            else
                Console.WriteLine("Strings are same !");
            if(a.Contains("World"))
                Console.WriteLine("World is in String a");
            Console.WriteLine(b.IndexOf('A'));
            b = string.Join(" ,", ar);
            Console.WriteLine(b);
            Console.ReadKey();
        }
    }
}
