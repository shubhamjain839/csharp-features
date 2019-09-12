using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace all_in_one
{
    class shape
    {
        public int side;
        public void get_side(int tside) {
            side = tside;
        }
    }
    class rectangle : shape
    {
        int wid;
        public void get_wid(int twid) { wid = twid; }
        public void cal_area() { Console.WriteLine("Area of Rectangle is :" + side * wid); }
    }
    class square : shape
    {
        public void cal_area() { Console.WriteLine("area of square is: " + side * side);  }
    }

    class inher
    {
        static void Main(string[] arg)
        {
            square S1 = new square();
            rectangle R1 = new rectangle();

            R1.get_side(12);
            R1.get_wid(2);
            R1.cal_area();

            S1.get_side(10);
            S1.cal_area();


            Console.ReadKey();
        }
    }
}
