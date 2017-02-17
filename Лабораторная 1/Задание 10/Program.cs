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
            string x, y;

            Console.WriteLine("Введите значение x");
            x = Console.ReadLine();

            Console.WriteLine("Введите значение y");
            y = Console.ReadLine();

            Console.WriteLine("INSERT INTO points (x, y) VALUES ('{0}', '{1}');", x, y);


        }
    }
}
