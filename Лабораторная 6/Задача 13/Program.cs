using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_13
{
    class Program
    {
  
         static void Main(string[] args)
        {
            int a = 20;
            int b = 40;
            int s = 0;

            while (a <= b)
            {
                s = a*a*a + s;
                a++;
            }

            Console.WriteLine(s);
        }
    }
}
