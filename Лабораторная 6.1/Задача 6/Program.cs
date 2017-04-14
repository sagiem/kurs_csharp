using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_6
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Введите P");
            int p = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите Q");
            int q = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите данные");
            string x = Console.ReadLine();

            string[] arr = x.Split(' ');

            string s;

            s = arr[p];
            arr[p] = arr[q];
            arr[q] = s;


            string result = string.Join(" ", arr);
            Console.WriteLine(result);

        


        }
    }
}
