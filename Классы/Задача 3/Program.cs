using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_3
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
            Interval l = new Interval();
            l.a = 2;
            l.b = 3;
            Interval r = new Interval();
            r.a = 5;
            r.b = 7;
            Boolean fact = l.Intersects(r);
            Console.WriteLine(fact);
        }

        static void Step2()
        {
            Interval l = new Interval();
            l.a = 11;
            l.b = 17;
            Interval r = new Interval();
            r.a = 13;
            r.b = 19;
            Console.WriteLine(r.Intersects(l));
        }

        static void Step3()
        {
            Interval l = new Interval();
            l.a = 5;
            l.b = 15;
            Interval r = new Interval();
            r.a = 0;
            r.b = 30;
            Console.WriteLine(l.Intersects(r));
        }

        static void Step4()
        {
            Interval l = new Interval();
            l.a = 67;
            l.b = 71;
            Interval r = new Interval();
            r.a = 59;
            r.b = 61;
            Console.WriteLine(l.Intersects(r));
        }

        static void Step5()
        {
            Interval l = new Interval();
            l.a = 79;
            l.b = 73;
            Interval r = new Interval();
            r.a = 83;
            r.b = 89;
            try
            {
                Console.WriteLine(l.Intersects(r));
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static void Step6()
        {
            Interval l = new Interval();
            l.a = 97;
            l.b = 101;
            Interval r = new Interval();
            r.a = 107;
            r.b = 103;
            try
            {
                Console.WriteLine(l.Intersects(r));
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static void Step7()
        {
            Interval l = new Interval();
            l.a = 127;
            l.b = 131;
            Interval r = null;
            try
            {
                Console.WriteLine(l.Intersects(r));
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
