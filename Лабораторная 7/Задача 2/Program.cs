using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string a, b, c = "abcdefwxyz";
            int  index = 0;

            Console.WriteLine("Введите a");
            a = Console.ReadLine();
            Console.WriteLine("Введите b");
            b = Console.ReadLine();


            int indexa = c.IndexOf(a);
            int indexb = c.IndexOf(b);
            if (indexa < 0 || indexb < 0)
            {
                Console.WriteLine("Сообщение об ошибке");
                return;
            }

            if (indexa < indexb)
            {
                index = indexb - indexa - 1;
            }

            else
            {
                index = indexa - indexb - 1;
            }



            Console.WriteLine(index);
        }
    }
}
