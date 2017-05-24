using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_6
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
        }

        static void Step1()
        {
            Point p = new Point();
            p.x = 127;
            p.y = 113;
            String str = p.Print();
            Console.WriteLine(str);
        }
        static void Step2()
        {
            Point p = new Point();
            p.x = 31;
            p.y = 37;
            Console.WriteLine(p.Print());
        }
        static void Step3()
        {
            Point p = new Point();
            p.SetCoordinates(5, 7);
            Console.WriteLine(p.Print());
        }
        static void Step4()
        {
            Point p1 = new Point();
            p1.SetCoordinates(23, 29);
            Console.WriteLine("Distance between {1} to (0;0) is {0:F4}", p1.DistanceTo(0, 0), p1.Print());
        }
        static void Step5()
        {
            Point p1 = new Point();
            p1.SetCoordinates(11, 13);
            Point p2 = new Point();
            p2.x = 17;
            p2.y = 19;
            Console.WriteLine("Distance between {0} and {1} is {2:F4}", p1.Print(), p2.Print(), p1.DistanceTo(p2));
        }
    }
}
