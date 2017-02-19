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
            double x, y, z;
            x = double.Parse(Console.ReadLine());
            y = double.Parse(Console.ReadLine());
            z = double.Parse(Console.ReadLine());

            if(x>-3&&x<5)
            {
                Console.Write(x);
                Console.Write(" ");
            }

            if (y > -3 && y < 5) 
            {
                Console.Write(y);
                Console.Write(" ");
            }

            if(z>-3&&z<5)
            {
                Console.WriteLine(z);
            }

        }
    }
}
