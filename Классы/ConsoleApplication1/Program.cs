using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            step1();
            step2();
            step3();
            step4();
            
        }

        static void step1()
        {
            Point p = new Point();
            p.x = 0;
            p.y = 0;
            double dist = p.DistanceTo(4, 3);
            Console.WriteLine(dist);
        }
        static void step2()
        {
            Point p = new Point();
            p.x = 0;
            p.y = 0;
            Console.WriteLine(p.DistanceTo(0, 0));
        }
        static void step3()
        {
            Point p = new Point();
            p.x = 19;
            p.y = 23;
            Console.WriteLine("{0:F4}",p.DistanceTo(11, 13));
        }
        static void step4()
        {
            Point p = new Point();
            p.x = 11;
            p.y = 23;
            Console.WriteLine(p.DistanceTo(11, 13));
        }
    }
}
