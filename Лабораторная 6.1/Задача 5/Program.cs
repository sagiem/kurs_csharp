using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите B");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите E");
            int e = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите данные");
            string x = Console.ReadLine();

            string[] arr = x.Split(' ');

            int y = arr.Length - 1;


            if (b < e)
            {
                while (b <= e)
                {
                    Console.Write(arr[b] + " ");

                    b++;

                }
            }
            else
            {
                while (e <= b)
                {
                    Console.Write(arr[e] + " ");

                    e++;

                }

            }


        }
    }
}
