using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            String t;
            t = Console.ReadLine();
            double l,p;
            l = double.Parse(t);
            p = double.Parse(Console.ReadLine());
            if (l < 0)
            {
                Console.WriteLine("Значение L должно быть неотрицательным");
                return;
            }
            if (p < 0)
            {
                Console.WriteLine("Значение P должно быть неотрицательным");
                return;
            }
            if (l * 1000 < p * 0.305)
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
