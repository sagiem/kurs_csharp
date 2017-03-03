using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double P, Q;
            Console.WriteLine("Введите P");
            P = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите Q");
            Q = double.Parse(Console.ReadLine());

            if(P>Q)
            {
                Console.WriteLine("Максимальное {0}, минимальное {1}", P, Q);
            }

            else
            {
                Console.WriteLine("Максимальное {0}, минимальное {1}", Q, P);
            }

        }
    }
}
