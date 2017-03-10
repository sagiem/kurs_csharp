using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_21
{
    class Program
    {
        static void Main(string[] args)
        {
            int W, i = 1;




            Console.WriteLine("Введите W");
            W = int.Parse(Console.ReadLine());

            //Console.Write("+");
            //Console.Write("|");
            //Console.Write("+");



            if (W < 0)
            {
                Console.WriteLine("Сообщение об ошибке");
                return;
            }

            W = W - 2;

            Console.Write("+");
            while (i <= W)
            {
                Console.Write("-");
                i++;
            }
            Console.Write("+");
            Console.WriteLine();
            i = 1;

            
            Console.Write("|");
            while (i <= W)
            {
                Console.Write(".");
                i++;
            }
            Console.Write("|");
            Console.WriteLine();
            i = 1;


           
            Console.Write("+");
            while (i <= W)
            {
                Console.Write("-");
                i++;
            }
            Console.Write("+");




        }
    }
}
