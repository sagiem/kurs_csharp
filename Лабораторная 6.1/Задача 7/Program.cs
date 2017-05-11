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
      
            int s = int.Parse(Console.ReadLine());
            string l = Console.ReadLine();
           
            string[] right = l.Split();
            int x = 0;



            for (int i = right.Length-1; i >= 0; i--)
            {
                x = int.Parse(right[i]) * s;
                Console.Write(x+" ");
            }
        }
    }
}
