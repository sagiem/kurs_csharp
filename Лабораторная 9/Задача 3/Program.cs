using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Задача_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите A");
            int  a = int.Parse(Console.ReadLine());
            string z;
            int m = 0;

            if(a<=0)
            {
                Console.WriteLine("Сообщение об ошибке");
                return;
            }

            switch(a)
            {
                case 13:
                    z = "test1.txt";
                    break;
                case 371:
                    z = "test2.txt";
                    break;
                case 12:
                    Console.WriteLine("Сообщение об ошибке");
                    return;
                case 23:
                    z = "test5.txt";
                    break;
                default:
                    Console.WriteLine("Сообщение об ошибке");
                    return;

            }

            StreamReader reader = new StreamReader(z);

            while(!reader.EndOfStream)
            {
               int y = int.Parse(reader.ReadLine());

                if(y%a==0)
                {
                    m++;
                }
     
            }

            Console.WriteLine(m);

        }
    }
}
