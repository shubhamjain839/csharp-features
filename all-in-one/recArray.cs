using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace all_in_one
{
    class recArray
    {
        static int row = 3, col = 4;
        static void Main(string[] args)
        {
            int[,] ar = new int[row,col];
            for(int i = 0; i < row; i++)
            {
                Console.WriteLine("Enter {0}th row elements :",i+1);
                for(int j = 0; j < col; j++)
                {
                    Console.Write("Enter {0}th element of {1}th row :", j + 1, i + 1);
                    ar[i, j] = int.Parse(Console.ReadLine());
                }
            }
            for (int i = 0; i < row; i++)
            {
                Console.WriteLine("{0}th row elements :", i + 1);
                for (int j = 0; j < col; j++)
                {
                    Console.WriteLine("{0}th element of {1}th row is {2}", j + 1, i + 1, ar[i, j]);
                }
            }
            Console.ReadKey();
        }
    }
}
