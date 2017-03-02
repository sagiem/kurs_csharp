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
            double V1, V2, S, T;
            Console.WriteLine("Введите V1");
            V1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите V2");
            V2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите S");
            S = double.Parse(Console.ReadLine());

            if (S == 0) 
            {
                Console.WriteLine("Уже встретились ! Ошибка эксперимента !");
                return;
            }

            if(V1<0||V2<0)
            {
                Console.WriteLine("Сообщение об ошибке");
                return;
            }

            T = S / (V1 + V2);

            Console.WriteLine("{0:N4}", T);
        }
    }
}
