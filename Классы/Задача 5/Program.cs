using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Step1();
            Step2();
            Step3();
            Step4();
        }

        static void Step1()
        {
            Interval l = new Interval();
            l.a = 2;
            l.b = 3;
            Interval r = new Interval();
            r.a = 5;
            r.b = 7;
            Console.WriteLine(Interval.AreIntersect(l, r));
        }

        static void Step2()
        {
            Interval l = new Interval();
            l.a = 11;
            l.b = 17;
            Interval r = new Interval();
            r.a = 13;
            r.b = 19;
            Console.WriteLine(Interval.AreIntersect(l, r));
        }

        static void Step3()
        {
            Interval l = new Interval();
            l.a = 79;
            l.b = 73;
            Interval r = new Interval();
            r.a = 83;
            r.b = 89;
            try
            {
                Console.WriteLine(Interval.AreIntersect(l, r));
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static void Step4()
        {
            Interval l = new Interval();
            l.a = 97;
            l.b = 101;
            Interval r = new Interval();
            r.a = 107;
            r.b = 103;
            try
            {
                Console.WriteLine(Interval.AreIntersect(r, l));
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
