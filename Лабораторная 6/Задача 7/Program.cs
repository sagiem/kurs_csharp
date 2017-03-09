using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            int b;

            while(a<=9)
            {
                b = a * 7;
                Console.WriteLine("{0} x 7 = {1}", a, b);
                a++;
            }
        }
    }
}
