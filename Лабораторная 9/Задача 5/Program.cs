using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Задача_5
{
    class Program
    {
        static void Main(string[] args)
        {

            string filename;
            string b;
            int m = 0;

            Console.WriteLine("Введите номер теста");
            int a = int.Parse(Console.ReadLine());
            
            if(a<1||a>5)
            {
                Console.WriteLine("Сообщение об ошибке");
                
                return;
            }

            switch(a)
            {
                case 2:
                    filename = "test2.txt";
                    break;

                case 3:
                    filename = "test3.txt";
                    break;

                default:
                    Console.WriteLine("Сообщение об ошибке");
                    return;
            }


            StreamReader reader = new StreamReader(filename);

            while (!reader.EndOfStream)
            {
                b = reader.ReadLine();

                string[] arr = b.Split();

                int v = int.Parse(arr[0]);
                int x = int.Parse(arr[1]);
                int c = int.Parse(arr[2]);
                int z = int.Parse(arr[3]);



                if(v==x||x==c||c==z)
                {
                    m++;
                }

            }

            Console.WriteLine(m);
        }


    }
}
