using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_11
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            int s = 0;


            Console.WriteLine("Введите a");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите b");
            b = int.Parse(Console.ReadLine());

            if (b<a)
            {
                Console.WriteLine("Сообщение об ошибке");
                return;
            }



            while (a <= b)
            {
                s = a + s;
                a++;
            }

            Console.WriteLine(s);
        }
    }
}
