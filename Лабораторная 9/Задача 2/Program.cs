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
                Console.WriteLine("Сообщение об ошибке");
                return;
            }

            StreamReader reader = new StreamReader(filename);
            decimal n = int.Parse(reader.ReadLine());
            decimal b = 0;
            decimal x = 0;
            int m = 0;
            int k = 0;

            if(n==0)
            {
                Console.WriteLine("Сообщение об ошибке");
                return;
            }

            while(!reader.EndOfStream)
            {
                b = decimal.Parse(reader.ReadLine());

                if(b<=20)
                {
                    x = x + b;
                    m++;
                }
                k++;
            }

            if (k == n)
            {
                n = x / m;

                Console.WriteLine("{0:N5}", n);
            }

            else { Console.WriteLine("Сообщение об ошибке"); return; }
        }
    }
}
