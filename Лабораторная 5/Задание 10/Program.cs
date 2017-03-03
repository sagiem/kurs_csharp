using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_10
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

            if(X>0)
            {
                X = X * X;
            }

            if (Y > 0)
            {
                Y = Y * Y;
            }

            if (Z > 0)
            {
                Z = Z * Z;
            }


            Console.WriteLine("{0} {1} {2}", X, Y, Z);
         




        }
    }
}
