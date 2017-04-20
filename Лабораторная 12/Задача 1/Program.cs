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

            Console.WriteLine("task4764");

            task4764("трудности");
            task4764("загадки");
            task4764("сложные задачи");

            Console.WriteLine("task2429");

            task2429("просто");
            task2429("интересно");
            task2429("перспективно");

            Console.WriteLine("task7472");

            Console.WriteLine("task2862");

            task2862();

            task7472("начало", "конец");
            task7472("сила", "знание");
            task7472("курица", "яйцо");
            task7472("шаг", "шаг");

            Console.WriteLine("task9231");

            task9231(9.780327);
            task9231(-273.15);
            task9231(0.00006);

            Console.WriteLine("task8624");

            task8624(811);
            task8624(1583);

            Console.WriteLine("task2959");

            task2959("123456789");
            task2959("fa93f");


        }

        static void task1860(string a)
        {
            Console.WriteLine("Мы стремимся к "+a);
        }

        static void task4764(string a)
        {
            Console.WriteLine(a + " нас не остановят!");
        }

        static void task2429(string a)
        {
            Console.WriteLine("Программирование это "+a);
        }



        static void task7472(string a, string b)
        {
            Console.WriteLine(b+" "+a);
        }

        static void task2862()
        {
            Console.WriteLine("{0:N4}",Math.PI);
            Console.WriteLine("{0:N4}",Math.E);
        }

        static void task9231(double a)
        {
            Console.WriteLine("{0:N4}",a);
        }

        static void task8624(int a)
        {
            Console.WriteLine("\"{0}\"",a);
        }

        static void task2959(string a)
        {
            Console.WriteLine("SELECT first_name, last_name, group FROM students WHERE student_id = '{0}'",a);
        }
    

    
    }
}
