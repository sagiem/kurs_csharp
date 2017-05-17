using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_18
{
    class Program
    {
        static void Main(string[] args)
        {
            int p = int.Parse(Console.ReadLine());
            int q = int.Parse(Console.ReadLine());
            string s = Console.ReadLine();
            string[] arr = s.Split();
            int x = int.Parse(arr[p]);

            for (int i = p; i < q; i++)
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
