using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_36
{
    class Program
    {
        static void Main(string[] args)
        {
            double Xa, Ya, Xb, Yb, AB;

            Console.WriteLine("Введите Xa");
            Xa = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите Ya");
            Ya = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите Xb");
            Xb = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите Yb");
            Yb = double.Parse(Console.ReadLine());

            AB = Math.Sqrt((Xb - Xa) * (Xb - Xa) + (Yb - Ya) * (Yb - Ya));

            Console.WriteLine("{0:N4}", AB);
        }
    }
}
