using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_1
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, d;
            a = double.Parse(Console.ReadLine());
            d = double.Parse(Console.ReadLine());

            if(a>d)
            {
                Console.WriteLine("первое");
            }
            else
            {
                Console.WriteLine("Второе");
            }

        }
    }
}
