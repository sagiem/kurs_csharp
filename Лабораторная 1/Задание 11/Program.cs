using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_11
{
    class Program
    {
        static void Main(string[] args)
        {
            string cx, cy, r, fill;

            Console.WriteLine("Введите значение cx");
            cx = Console.ReadLine();

            Console.WriteLine("Введите значение cy");
            cy = Console.ReadLine();

            Console.WriteLine("Введите значение r");
            r = Console.ReadLine();

            Console.WriteLine("Введите значение fill");
            fill = Console.ReadLine();

            Console.WriteLine("<circle cx=\"{0}\" cy=\"{1}\" r=\"{2}\" fill=\"{3}\"/>", cx, cy, r, fill);

        }
    }
}
