using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_11
{
    class Program
    {
        static void Main(string[] args)
        {
            mymetod1();
            mymetod2();
            mymetod3();
            mymetod4();
        }

        static void mymetod1()
        {
            Point p = new Point();
            p.x = 31;
            p.y = 37;
            Console.WriteLine(p.Print());
        }

        static void mymetod2()
        {
            Point p = new Point();
            p.SetCoordinates(5, 7);
            Console.WriteLine(p.Print());
        }

        static void mymetod3()
        {
            Point p1 = new Point();
            p1.SetCoordinates(23, 29);
            Console.WriteLine("Distance between " + p1.Print()
            + " to (0;0) is {0:F4}", p1.DistanceTo(0, 0));
        }

        static void mymetod4()
        {
            Point p1 = new Point();
            p1.SetCoordinates(11, 13);
            Point p2 = new Point();
            p2.x = 17;
            p2.y = 19;
            Console.WriteLine("Distance between " + p1.Print()
            + " and " + p2.Print() + " is {0:F4}", + p1.DistanceTo(p2));
        }
    }
}
