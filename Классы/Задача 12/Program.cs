using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Step1();
            Step2();
            Step3();
            Step4();
            Step5();
            Step6();
            Step7();
        }

        static void Step1()
        {
            Point p = new Point(53, 59);
            Console.WriteLine(p.Print());
        }

        static void Step2()
        {
            Point p1 = new Point(53, 59);
            Point p2 = new Point(61, 67);
            Console.WriteLine("Distance between " + p1.Print()+ " and " + p2.Print() + " is " + p1.DistanceTo(p2));
        }

        static void Step3()
        {
            double dist = new Point(79, 83).DistanceTo(new Point(89, 97));
            Console.WriteLine(dist);
        }

        static void Step4()
        {
            Point p = new Point(71, 73);
            Console.WriteLine("Distance between " + p.Print()+ " to zero is " + p.DistanceTo(new Point(0, 0)));
        }

        static void Step5()
        {
            Console.WriteLine(new Point(79, 83).DistanceTo(new Point(89, 97)));
        }

        static void Step6()
        {
            double dist = Point.DistanceBetween(new Point(151, 157),new Point(163, 167));
            Console.WriteLine(dist);
        }

        static void Step7()
        {
            Console.WriteLine(Point.DistanceBetween(new Point(173, 179),new Point(181, 191)));
        }

    }
}
