using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_7
{
    class Program
    {
        static void Main(string[] args)
        {
            mymetod1();
            mymetod2();
        }

        static void mymetod1()
        {
            Interval l = new Interval();
            l.a = 11;
            l.b = 17;
            Console.WriteLine(l.Contains(0));
            Console.WriteLine(l.Contains(15));
            Console.WriteLine(l.Contains(20));
        }

        static void mymetod2()
        {
            Interval range = new Interval();
            range.a = 19;
            range.b = 17;
            try
            {
                Console.WriteLine(range.Contains(18));
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
