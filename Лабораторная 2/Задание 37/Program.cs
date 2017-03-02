using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_37
{
    class Program
    {
        static void Main(string[] args)
        {
            double V1, V2, T1, T2, V, T;

            Console.WriteLine("Введите V1");
            V1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите T1");
            T1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите V2");
            V2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите T2");
            T2 = double.Parse(Console.ReadLine());

            if(V1<=0||V2<=0)
            {
                Console.WriteLine("Сообщение об ошибке");
                return;
            }

            V = V1 + V2;

            T = (T1 * V1 + T2 * V2) / (V1 + V2);

            Console.WriteLine("{0} {1:N4}",V, T);
        }
    }
}
