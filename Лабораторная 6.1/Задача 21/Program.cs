using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_21
{
    class Program
    {
        static void Main(string[] args)
        {
            int k = int.Parse(Console.ReadLine());
            string s = Console.ReadLine();
            string[] arr = s.Split();
            int m = 0;

            for(int i = 0; i < arr.Length; i++)
            {
                int x = int.Parse(arr[i]);
                    if(k==x)
                    {
                        m++;
                    }
            }

            Console.WriteLine(m);
        }
    }
}
