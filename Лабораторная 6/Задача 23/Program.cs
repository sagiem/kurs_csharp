using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_23
{
    class Program
    {
        static void Main(string[] args)
        {
            int H, i=1, q=1;
            string S;

            Console.WriteLine("Введите S");
            S = Console.ReadLine();
            Console.WriteLine("Введите H");
            H = int.Parse(Console.ReadLine());


            
            if(H<0)
            {
                Console.WriteLine("Сообщение об ошибке");
                return;
            }

            while(i<=H)
            {
                while (q <= i)
                {
                    Console.Write(S);
                    q++;
                }
                q = 1;
                i++;
                Console.WriteLine();
            }


        }
    }
}
