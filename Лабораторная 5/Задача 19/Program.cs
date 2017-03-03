using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_19
{
    class Program
    {
        static void Main(string[] args)
        {
            double A, B, C, D;

            Console.WriteLine("Введите A");
            A = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите B");
            B = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите C");
            C = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите D");
            D = double.Parse(Console.ReadLine());

            if (A <= 0 || B <= 0 || C <= 0 || D <= 0) 
            {
                Console.WriteLine("Сообщение об ошибке");
                return;
            }

            if(A<C&&B<D)
            {
                Console.WriteLine("Размещение возможно");
            }

            else
            {
                Console.WriteLine("Размещение невозможно");
            }



        }
    }
}
