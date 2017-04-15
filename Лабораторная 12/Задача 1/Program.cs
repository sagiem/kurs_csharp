using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("1860");

            task1860("знаниям");
            task1860("цели");
            task1860("результату");

            Console.WriteLine("7472");

            task7472("начало", "конец");
            task7472("сила", "знание");
            task7472("курица", "яйцо");
            task7472("шаг", "шаг");

            Console.WriteLine("task9231");

            task9231(9.780327);
            task9231(-273.15);
            task9231(0.00006);


        }

        static void task1860(string a)
        {
            Console.WriteLine("Мы стремимся к "+a);
        }

        static void task7472(string a, string b)
        {
            Console.WriteLine(b+" "+a);
        }

        static void task9231(double a)
        {
            Console.WriteLine("{0:N4}",a);
        }
    }
}
