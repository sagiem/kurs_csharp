using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_19
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            string y = Console.ReadLine();
            string s = Console.ReadLine();
            string[] arr = s.Split();
            

            for (int i = 0; i < arr.Length; i++)
            {

                int a = int.Parse(arr[i]);

                if (a == x)
                {
                    arr[i] = y;
                }

                Console.Write(arr[i] + " ");
            }

            
        }
    }
}
