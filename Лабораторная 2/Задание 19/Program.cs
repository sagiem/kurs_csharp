using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_19
{
    class Program
    {
        static void Main(string[] args)
        {
            double v0, t, a, R;
            Console.WriteLine("Введите v0");
            v0 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите t");
            t = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите a");
            a = double.Parse(Console.ReadLine());

            R = v0 * t + a * t * t / 2;
            Console.WriteLine("{0:N1}", R);

        }
    }
}
