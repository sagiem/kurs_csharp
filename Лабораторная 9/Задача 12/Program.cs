using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Задача_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите номер теста");
            string filename = Console.ReadLine();
            filename = "test" + filename + ".txt";

            if (!File.Exists(filename))
            {
                Console.WriteLine("Сообщение об ошибке");
                return;
            }

            StreamReader reader = new StreamReader(filename);
            string b = reader.ReadLine();
           
            while(!reader.EndOfStream)
            {
                b = reader.ReadLine();
                string[] arr = b.Split('@');

                Console.WriteLine(arr.Length);

                //if(arr.Length==2)
                //{
                //    Console.WriteLine(arr[0]);
               // }
                //else
                //{
                //    Console.WriteLine("Сообщение об ошибке");
                 //   return;
               // }
            }
        }
    }
}
