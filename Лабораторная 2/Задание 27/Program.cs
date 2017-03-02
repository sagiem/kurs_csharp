using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_27
{
    class Program
    {
        static void Main(string[] args)
        {
            double s, R;

            Console.WriteLine("Введите s");
            s = double.Parse(Console.ReadLine());

            R = Math.Sqrt(1 - Math.Sin(s * Math.PI / 180) * Math.Sin(s * Math.PI / 180));

            Console.WriteLine("{0:N4}", R);


        }
    }
}
