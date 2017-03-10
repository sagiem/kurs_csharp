using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_20
{
    class Program
    {
        static void Main(string[] args)
        {
            int W, H, i=1, q=1;
            string S;



            Console.WriteLine("Введите S");
            S = Console.ReadLine();
            Console.WriteLine("Введите W");
            W = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите H");
            H = int.Parse(Console.ReadLine());
            

            if (H<0||W<0)
            {
                Console.WriteLine("Сообщение об ошибке");
                return;
            }

           
            while (i <= H)
            {
                Console.WriteLine();

             while(q<=W)
             {
                 Console.Write(S);
                 q++;

             }
             q = 1;
             i++;
     
            }

           
        }
    }
}
