using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_10
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
            range.a = 31;
            range.b = 37;
            try
            {
                range.Squeeze(2);
                Console.WriteLine("Интервал успешно изменен");
                Console.WriteLine(range.Print());
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static void mymetod2()
        {
            Interval range = new Interval();
            range.a = 41;
            range.b = 43;
            try
            {
                range.Squeeze(19);
                Console.WriteLine("Интервал успешно изменен");
                Console.WriteLine(range.Print());
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static void mymetod3()
        {
            Interval range = new Interval();
            range.a = 101;
            range.b = 67;
            try
            {
                range.Squeeze(23);
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
