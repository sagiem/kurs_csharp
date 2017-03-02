using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_8
{
    class Program
    {
        static void Main(string[] args)
        {
            int t, l, v, n;

            Console.WriteLine("Введите t");
            t = 100 * int.Parse(Console.ReadLine());

            Console.WriteLine("Введите l");
            l = int.Parse(Console.ReadLine());

            if(t<=0||l<=0)
            {
                Console.WriteLine("Сообщение об ошибке");
                return;
            }

            v = t / l;
            n = t % l;

            Console.WriteLine("{0:N0} и {1} см", v, n);

        }
    }
}
