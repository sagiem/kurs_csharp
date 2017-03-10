using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_17
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 100, b = 1000;
            int s = 0;
            int i = 0;



            a = a - 1;
            while (a < b)
            {
                a++;
               

                if (a % 13 == 0)
                {
                    s++;
                }
                
            }

            Console.WriteLine(s);
        }
    }
}
