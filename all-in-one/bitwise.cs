using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace all_in_one
{
    public class cl1
    {
       public int test;
       public cl1(int t_test)
        {
            test = t_test;
        }
    }
    public class cl2
    {
        public string test2;
        public cl2(string t_test2)
        {
            test2 = t_test2;
        }

    }
    class bitwise
    {
        static void Main(string[] arg)
        {
            cl1 ob1 = new cl1(12);
            cl2 ob2 = new cl2("jasdeep");
            if(ob1 is cl1)
            {
                Console.WriteLine("object is same as class");
            }
            if(!(ob2 is cl1))
            {
                Console.WriteLine("object isnt of same class");
            }   
            string a = ob2.test2 as string;
            Console.WriteLine(a);
            Console.ReadKey();
        }
    }
}
