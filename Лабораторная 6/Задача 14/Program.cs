using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_14
{
    class Program
    {
        static void Main(string[] args)
        {
            double i = 1;
            double n;
            double s = 0;

            Console.WriteLine("Введите n");
            n = double.Parse(Console.ReadLine());

            if(n<=0)
            {
                Console.WriteLine("Сообщение об ошибке");
                return;
            }

            while(i<=n)
            {
                s = s+1/i++;
            }

            Console.WriteLine("{0:N4}", s);

        }
    }
}
