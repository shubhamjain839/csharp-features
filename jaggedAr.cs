using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace all_in_one
{
    class jaggedAr
    {
        static int size = 3;
        static void Main(string[] arg)
        {
            int[][] jAr = new int[size][];
            for(int i = 0; i<size;i++)
            {
                int tempLenght;
                Console.Write("Enter size of array :");
                tempLenght = int.Parse(Console.ReadLine());
                jAr[i] = new int[tempLenght];
                for (int j = 0; j < tempLenght; j++)
                {
                    Console.Write("Enter {0}th Element :",j+1);
                    jAr[i][j] = int.Parse(Console.ReadLine());
                }
            }
            for (int i=0;i<size;i++)
            {
                Console.WriteLine("Array :{0}",i+1);
                for(int j=0;j<jAr[i].Length;j++)
                {
                    Console.WriteLine("{0} th Element of {1} Array is : {2}",j+1,i+1,jAr[i][j]);
                }
            }
            Console.ReadKey();
        }
    }
}