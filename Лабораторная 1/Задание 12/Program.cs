using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_12
{
    class Program
    {
        static void Main(string[] args)
        {
            string user, pass, host, port, db;

            Console.WriteLine("Введите значение user");
            user = Console.ReadLine();

            Console.WriteLine("Введите значение pass");
            pass = Console.ReadLine();

            Console.WriteLine("Введите значение host");
            host = Console.ReadLine();

            Console.WriteLine("Введите значение port");
            port = Console.ReadLine();

            Console.WriteLine("Введите значение db");
            db = Console.ReadLine();

            Console.WriteLine("User ID={0};Password={1};Host={2};Port={3};Database={4};", user, pass, host, port, db);
        }
    }
}
