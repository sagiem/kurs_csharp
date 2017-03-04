using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_22
{
    class Program
    {
        static void Main(string[] args)
        {
            double A1, B1, A2, B2;

            Console.WriteLine("Введите A1");
            A1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите B1");
            B1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите A2");
            A2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите B2");
            B2 = double.Parse(Console.ReadLine());

            if(A1>B1||A2>B2)
            {
                Console.WriteLine("Сообщение об ошибке");
                return;
            }

            if (A2 > A1 && A2 < B1)
            {
                if (B1 > A2 && B1 < B2)
                {
                    Console.WriteLine("Пересекаются ({0};{1})", A2, B1);
                    return;
                }

                if (B2 > A1 && B2 < B1)
                {
                    Console.WriteLine("Пересекаются ({0};{1})", A2, B2);
                    return;
                }
            }

            if(A1>A2&&A1<B2&&B2>A1&&B2<B1)
            {
                Console.WriteLine("Пересекаются ({0};{1})", A1, B2);
                return;
            }

            if(A1>A2&&A1<B2&&B1>A2&&B1<B2)
            {
                Console.WriteLine("Пересекаются ({0};{1})", A1,B1);
                return;
            }

            Console.WriteLine("не пересекаются");

        }
    }
}
