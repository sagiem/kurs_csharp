using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string messege;

            Console.WriteLine("Введите текст");
            messege = Console.ReadLine();

            Console.WriteLine("Решение 1");
            Console.WriteLine("Программирование это {0} !", messege);

            Console.WriteLine("Решение 2");
            Console.WriteLine("Программирование это " + messege + " !");

            Console.WriteLine("Решение 3");
            Console.Write("Программирование это ");
            Console.Write(messege);
            Console.WriteLine(" !");


            


        }
    }
}
