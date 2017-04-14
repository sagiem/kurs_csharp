using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            string[] arr;
            a = int.Parse(Console.ReadLine());
            string raw = Console.ReadLine();
            if(string.IsNullOrWhiteSpace(raw))
            {
                Console.WriteLine("Исходная строка пуста");
                return;
            }

            arr = raw.Split(' ');
            if(a>=arr.Length||a<0)
            {
                Console.WriteLine("Значение A должно быть в интервале [0, размер массива");
                return;
            }

            Console.WriteLine(arr[a]);
        }
    }
}
