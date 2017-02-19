using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_3
{
    class Program
    {
        static void Main(string[] args)
        {
            double k, x;
            k = double.Parse(Console.ReadLine());

            if(k>0)
            {
                x = Math.Sqrt(k);
                
                
            }
            else
            {
                x = k * k;
                
            }

            Console.WriteLine(x);
        }
    }
}
