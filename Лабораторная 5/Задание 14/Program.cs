using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_14
{
    class Program
    {
        static void Main(string[] args)
        {
            double A, B, C;

            Console.WriteLine("Введите A");
            A = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите B");
            B = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите C");
            C = double.Parse(Console.ReadLine());

            if(A<=0||B<=0||C<=0)
            {
                Console.WriteLine("Сообщение об ошибке");
            }



            if(A==B||B==C||A==C)
            {
                Console.WriteLine("Треугольник является равнобедренным.");
            }

            else
            {
                Console.WriteLine("Треугольник не является равнобедренным.");
            }

        }
    }
}
