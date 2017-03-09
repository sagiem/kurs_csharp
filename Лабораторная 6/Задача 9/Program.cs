using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_9
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b = 500;
            int s = 0;

            Console.WriteLine("Введите a");
            a = int.Parse(Console.ReadLine());

            if (a < -100 || a > 500)
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
