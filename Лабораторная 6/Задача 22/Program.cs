using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_22
{
    class Program
    {
        static void Main(string[] args)
        {
            int W, H, i = 0, q = 0, z = 0;


            Console.WriteLine("Введите W");
            W = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите H");
            H = int.Parse(Console.ReadLine());

            if(W<0||H<0)
            {
                Console.WriteLine("Сообщегие об ошибке");
                return;
            }
            
            Console.Write(" ");
            
            while(i<W)
            {
                Console.Write(i);
                i++;
            }

            while(q<H)
            {
                Console.WriteLine();
                Console.Write(q);
                while(z<i)
                {
                    Console.Write(" ");

                    z++;
                }

                z = 0;

                Console.Write("|");

                q++;
            }

            z = 0;
            Console.WriteLine();
            while (z < i)
            {
                Console.Write("-");

                z++;
            }



        }
    }
}
