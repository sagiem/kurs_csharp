using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_16
{
    class Program
    {
        static void Main(string[] args)
        {
            double M, P;

            Console.WriteLine("Введите M");
            M = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите P");
            P = double.Parse(Console.ReadLine());

            if(P==0)
            {
                Console.WriteLine("Сообщение об ошибке");
                return;
            }

            if(M%P==0)
            {
                M = M / P;
                Console.WriteLine(M);
            }
            else
            {
                Console.WriteLine("M не делится нацело на P");
            }
        }
    }
}
