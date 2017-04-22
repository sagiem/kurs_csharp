using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Задача_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите номер теста");
            string index = Console.ReadLine();
            string filename = "test" + index + ".txt";

            if (!File.Exists(filename))
            {
                Console.WriteLine("Файл не существует");
                return;
            }

            try
            {
                using (StreamReader reader = new StreamReader(filename))
                {
                    decimal p = task0000(reader);
                    Console.WriteLine("{0:N4}", p);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        static decimal task0000(StreamReader reader)
        {
            decimal n = int.Parse(reader.ReadLine());
            decimal b = 0;
            decimal x = 0;
            int m = 0;
            int k = 0;

            if (n == 0)
            {
                return 0;
            }

            while (!reader.EndOfStream)
            {
                b = decimal.Parse(reader.ReadLine());

                if (b <= 20)
                {
                    x = x + b;
                    m++;
                }
                k++;
            }

            if (k == n)
            {
                n = x / m;
                return n;
            }
            else
            {
                Exception e = new Exception("Некорректный объем данных");
                throw e;
            }
        }
    }
}
