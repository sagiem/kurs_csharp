using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Задача_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string t;
            int x, y;
            Console.WriteLine("Введите номер теста");
            int a = int.Parse(Console.ReadLine());

            switch(a)
            {
                case 1:
                    t = "test1.txt";
                    break;
                case 2:
                    t = "test2.txt";
                    break;
                case 3:
                    t = "test3.txt";
                    break;
                default:
                    Console.WriteLine("Сообщение об ошибке");
                    return;
            }

            StreamReader reader = new StreamReader(t);

            x = int.Parse(reader.ReadLine());
            y = x;

            while(!reader.EndOfStream)
            {
                x = int.Parse(reader.ReadLine());

                if(x<y)
                {
                    y = x;
                }

            }

            Console.WriteLine(y);
        }
    }
}
