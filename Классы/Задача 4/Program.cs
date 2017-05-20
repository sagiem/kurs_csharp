using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Step1();
            Step2();
        }

        static void Step1()
        {
            Point p1 = new Point();
            p1.x = 109;
            p1.y = 113;
            Point p2 = new Point();
            p2.x = 127;
            p2.y = 131;
            double dist = Point.DistanceBetween(p1, p2);
            Console.WriteLine("{0:F4}",dist);
        }

        static void Step2()
        {
            Point p1 = new Point();
            p1.x = 137;
            p1.y = 139;
            Point p2 = new Point();
            p2.x = 139;
            p2.y = 149;
            Console.WriteLine("{0:F4}", Point.DistanceBetween(p1, p2));
        }
    }
}
