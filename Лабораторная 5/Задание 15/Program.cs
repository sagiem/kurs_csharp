using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_15
{
    class Program
    {
        static void Main(string[] args)
        {
            double X, Y, Z;

            Console.WriteLine("Введите X");
            X = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите Y");
            Y = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите Z");
            Z = double.Parse(Console.ReadLine());

            if(X>Y&&X>Z)
            {
                Console.WriteLine(X);
                return;
            }

            if(Y>X&&Y>Z)
            {
                Console.WriteLine(Y);
                return;
            }

            if(Z>X&&Z>Y)
            {
                Console.WriteLine(Z);
                
            }
        }
    }
}
