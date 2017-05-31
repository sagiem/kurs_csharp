using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_8
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
            Interval range = new Interval();
            range.a = 23;
            range.b = 29;
            Console.WriteLine(range.Print());
        }

        static void mymetod2()
        {
            Interval range = new Interval();
            range.a = 31;
            range.b = 29;
            try
            {
                Console.WriteLine(range.Print());
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
