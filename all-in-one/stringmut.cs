using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace all_in_one
{
    class stringmut
    {
        static void Main(string[] arg)
        {
            StringBuilder ab = new StringBuilder(20);
            ab.Append("hello ");
            Console.WriteLine(ab);
            ab.Insert(6, "World! ");
            Console.WriteLine(ab);
            ab.Insert(13, "bye");
            Console.WriteLine(ab);
            ab.Remove(12, 4);
            Console.WriteLine(ab);
            ab.Replace("hello ", "bye ");
            Console.WriteLine(ab);
            Console.ReadKey();

            
        }
    }
}
