using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_16
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            int s =0;
            int i = 0;
            

            Console.WriteLine("Введите a");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите b");
            b = int.Parse(Console.ReadLine());
            if(b<a)
            {
                Console.WriteLine("Сообщение об ошибке");
            }

            a = a - 1;
            while(a>b)
            {
               a++;
                Console.WriteLine(a);
                
                

                if(a%7==0)
                {
                    s = s + a;
                }
                i = i + 1;
            }

            Console.WriteLine(s);
        }
    }
}
