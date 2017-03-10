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
            string a, b = "abcdefwxyz";

            Console.WriteLine("Введите a");
            a = Console.ReadLine();

            int index = b.IndexOf(a);
            if(index<0)
            {
                Console.WriteLine("Сообщение об ошибке");
                return;
            }

            index = b.Length - index - 1;



            Console.WriteLine(index);
        }
    }
}
