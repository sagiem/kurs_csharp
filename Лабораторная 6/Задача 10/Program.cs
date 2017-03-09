using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_10
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = -10;
            int b;
            int s = 0;

            Console.WriteLine("Введите a");
            b = int.Parse(Console.ReadLine());

            if (b<-10)
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
