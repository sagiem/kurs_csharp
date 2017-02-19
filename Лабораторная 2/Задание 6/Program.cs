using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_6
{
    class Program
    {
        static void Main(string[] args)
        {
            double s, a, h;

            Console.WriteLine("Введите значение a");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите значение h");
            h = Double.Parse(Console.ReadLine());
            
            if(a<=0)
            {
                Console.WriteLine("Ошибка");
                return;
            }

            if(h<=0)
            {
                Console.WriteLine("Ошибка");
                return;
            }

            s = a * h / 2;
            Console.WriteLine(s);
        }
    }
}
