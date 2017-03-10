using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string a, b, c= "abcdefwxyz";

            Console.WriteLine("Введите a");
            a = Console.ReadLine();
            Console.WriteLine("Введите b");
            b = Console.ReadLine();

            int indexa = c.IndexOf(a);
            int indexb = c.IndexOf(b);

            if(indexa<0||indexb<0)
            {
                Console.WriteLine("Сообщение об ошибке");
                return;
            }

            if(indexa < indexb)
            {
               Console.WriteLine(c.Substring(indexa+1, (indexb-indexa -1))); 
            }
            else
            {
                Console.WriteLine(c.Substring(indexb+1, (indexa-indexb -1))); 
            }

           
        }
    }
}
