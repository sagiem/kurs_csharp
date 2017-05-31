using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_9
{
    class Program
    {
        static void Main(string[] args)
        {
            mymetod1();
            mymetod2();
            mymetod3();
        }

        static void mymetod1()
        {
            Interval range = new Interval();
            range.a = 5;
            range.b = 11;
            range.Slide(7);
            Console.WriteLine("Интервал успешно изменен");
            Console.WriteLine(range.Print());
        }

        static void mymetod2()
        {
            Interval range = new Interval();
            range.a = 17;
            range.b = 29;
            range.Slide(-4);
            Console.WriteLine("Интервал успешно изменен");
            Console.WriteLine(range.Print());
        }

        static void mymetod3()
        {
            Interval range = new Interval();
            range.a = 37;
            range.b = 31;
            try
            {
                range.Slide(2);
                Console.WriteLine("Интервал успешно изменен");
                Console.WriteLine(range.Print());
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
