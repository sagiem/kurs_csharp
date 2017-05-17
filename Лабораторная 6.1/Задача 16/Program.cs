using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_16
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            string[] arr = s.Split();
            int x = int.Parse(arr[0]);

            for (int i = 1; i < arr.Length; i++)
            {

                int a = int.Parse(arr[i]);

                if (a < x)
                {
                    x = a;
                }

            }

            Console.WriteLine(x);
        }
    }
}
