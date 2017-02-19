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
            double x, y, z;
            x = double.Parse(Console.ReadLine());
            y = double.Parse(Console.ReadLine());
            z = double.Parse(Console.ReadLine());

            if(x==y||y==z||z==x)
            {
                Console.WriteLine("среди чисел есть равные");
            }
            else
            {
                Console.WriteLine("Числа не равны друг другу");
            }
        }
    }
}
