using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_5
{
    class Program
    {
        static void Main(string[] args)
        {
            string a, b;

            Console.WriteLine("Введите первую строку");
            a = Console.ReadLine();
            Console.WriteLine("Введите вторую строку");
            b = Console.ReadLine();

            Console.WriteLine("Решение 1");
            Console.WriteLine("{1} {0}", a, b);

            Console.WriteLine("Решение 2");
            Console.WriteLine(b +" "+ a);

            Console.WriteLine("Решение 3");
            Console.Write(b);
            Console.Write(" ");
            Console.WriteLine(a);


        }
    }
}
