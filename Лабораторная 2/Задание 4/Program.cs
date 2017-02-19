using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_4
{
    class Program
    {
        static void Main(string[] args)
        {
            double c;
            double r;

            r = double.Parse(Console.ReadLine());

            if(r<=0)
            {
                Console.WriteLine("Ошибка");
                return;
            }

            c = 2 * Math.PI * r;
            Console.WriteLine("{0:N4}",c);
        }
    }
}
