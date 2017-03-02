using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_24
{
    class Program
    {
        static void Main(string[] args)
        {
            double y, m1, m2, r, C;

            Console.WriteLine("Введите y");
            y = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите m1");
            m1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите m2");
            m2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите r");
            r = double.Parse(Console.ReadLine());
            if(r==0)
            {
                Console.WriteLine("Сообщение об ошибке");
                return;
            }

            C = y * ((m1 * m2) / (r * r));
            Console.WriteLine("{0:N4}", C);

        }
    }
}
