using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите X");
            string x = Console.ReadLine();

            string[] arr = { "11", "13", "17", "19", "10", "12", "14", "15", "16", "18", "20" };


            int n = 0;

            while (n < arr.Length)
            {

                if (x == arr[n])
                {
                    Console.WriteLine(arr[n] + "+");
                }

                else
                {
                    Console.WriteLine(arr[n]);
                }

                n++;
            }
        }
    }
}
