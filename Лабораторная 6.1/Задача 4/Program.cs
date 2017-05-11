using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            string l = Console.ReadLine();
            string[] left = s.Split();
            string[] right = l.Split();
            int x = 0;

            if(left.Length!=right.Length)
            {
                Console.WriteLine("Размеры массивов должны быть одинаковы");
                return;
            }

            for(int i=0; i<left.Length; i++)
            {
                x = int.Parse(left[i]) * int.Parse(right[i]);
                Console.Write(x+" ");
            }

        }
    }
}
