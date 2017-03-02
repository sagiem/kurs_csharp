using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_12
{
    class Program
    {
        static void Main(string[] args)
        {
            double y, r;

            Console.WriteLine("Введите y");
            y = double.Parse(Console.ReadLine());
            r = 5 * Math.Cos((y * Math.PI / 180));
            Console.WriteLine("{0:N4}", r);
        }
    }
}
