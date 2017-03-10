using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_24
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B, z = 0, q = 1;

            Console.WriteLine("Введите A");
            A = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите B");
            B = int.Parse(Console.ReadLine());

            if (B < A)
            {
                Console.WriteLine("Сообщение об ошибке");
                return;
            }

            A = A - 1;
            while (A <= B)
            {
                A = A + 1;


                if(A % 2 != 0)
                {
                    while (q <= z)
                    {
                        Console.Write(".");
                        q++;
                    }
                    Console.WriteLine(A);
                    z++;
                }

                q = 1;

                

            }


        }
    }
}
