using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_25
{
    class Program
    {
        static void Main(string[] args)
        {
            int H, W, i=0, q=0, z=0, y=0;

            Console.WriteLine("Введите H");
            H = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите W");
            W = int.Parse(Console.ReadLine());

            y = H;
            z = H;
            
            
            while(i<W)
            {
                while(q<y)
                {
                    Console.Write("+");

                    q++;
                }
                

                while(z>y)
                {
                    Console.Write("#");

                    z--;

                }

                y--;
                i++;
                q = 0;
                z = H;
                
                
                Console.WriteLine();
            }
        }
    }
}
