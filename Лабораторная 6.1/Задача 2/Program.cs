using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();

            string[] arr = a.Split(' ');

            int n = arr.Length-1;

            while(n>=0)
            {
                Console.Write(arr[n]+" ");
                n--;
            }
        }
    }
}
