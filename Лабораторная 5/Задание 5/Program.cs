using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_5
{
    class Program
    {
        static void Main(string[] args)
        {
            double L, P;

            Console.WriteLine("Введите L");
            L = (double.Parse(Console.ReadLine()))*1000;
            Console.WriteLine("Введите t");
            P = (double.Parse(Console.ReadLine()))*0.305;

            if(L<P)
            {
                Console.WriteLine("Расстояние в километрах меньше");
            }
            else
            {
                Console.WriteLine("Расстояние в футах меньше");
            }
        }
    }
}
