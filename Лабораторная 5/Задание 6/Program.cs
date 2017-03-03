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
            double V1, V2, V3;

            Console.WriteLine("Введите V1");
            V1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите V2");
            V2 = double.Parse(Console.ReadLine());

            V3=((V1*1000)/60)/60;

            if(V1<0||V2<0)
            {
                Console.WriteLine("Сообщение об ошибке");
                return;
            }

            if(V2<V3)
            {
                Console.WriteLine("{0} (м/с) меньше {1}(км/ч)", V2, V1);
            }

            else
            {
                Console.WriteLine("{0} (км/ч) меньше {1}(м/с)", V1, V2);
            }

      



        }
    }
}
