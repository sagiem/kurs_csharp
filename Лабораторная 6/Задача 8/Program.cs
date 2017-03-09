using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_8
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 100;
            int b = 500;
            int s= 0;

            while(a<=b)
            {
                s = a + s;
                a++;
            }

            Console.WriteLine(s);
        }
    }
}
