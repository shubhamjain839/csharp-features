using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace all_in_one
{
    class switchFall
    {
        static void Main(string[] arg)
        {
            int a;
            do
            {
                a = int.Parse(Console.ReadLine());
                switch (a)
                {
                    case 1:
                    case 2:
                    case 3:
                    case 4:
                        Console.WriteLine("Fall Through Occuring");
                        break;
                    default:
                        Console.WriteLine("Default Case");
                        break;
                }
                a = int.Parse(Console.ReadLine());
                switch (a)
                {
                    case 1:
                        Console.WriteLine("Jumped To Case 1");
                        goto case 2;
                    case 2:
                        Console.WriteLine("Jumped To Case 2");
                        break;
                    case 3:
                        Console.WriteLine("Jumped To Case 2");
                        goto case 1;
                    default:
                        Console.WriteLine("default case !");
                        break;
                }
            } while (a < 5);
        }
    }
}
