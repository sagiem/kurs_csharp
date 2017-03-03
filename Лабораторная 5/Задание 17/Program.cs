using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_17
{
    class Program
    {
        static void Main(string[] args)
        {

            double A;

            Console.WriteLine("Введите A");
            A = double.Parse(Console.ReadLine());

            if(A<1000||A>9999)
            {
                Console.WriteLine("Сообщение об ошибке");
                return;

            }

            if (A % 10 == ((A % 1000 - A % 100) / 100))
            {
                Console.WriteLine("равно");
            }
            else
            {
                Console.WriteLine("не равно");
            }
        }
    }
}
