using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Задача_6
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Введите номер теста");
            string index = Console.ReadLine();
            string filename = "test" + index + ".csv";
            string a;
            int x = 0;
            int y = 0;

            if (!File.Exists(filename))
            {
                Console.WriteLine("Сообщение об ошибке");
                return;
            }

            StreamReader reader = new StreamReader(filename);

            while (!reader.EndOfStream)
            {
                a = reader.ReadLine();
                string[] arr = a.Split(';');

                x = int.Parse(arr[2]) * int.Parse(arr[3]);

                if(x>y)
                {
                    y = x;
                }

            }

            Console.WriteLine(y);
        }
    }
}
