using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();

            string[] arr = s.Split();
            double y = 0;

            for(int i=0; i<arr.Length; i++)
            {
                double x = double.Parse(arr[i]);
                y = y + x;
            }

            y = y / arr.Length;
            Console.WriteLine(y);
        }
    }
}
