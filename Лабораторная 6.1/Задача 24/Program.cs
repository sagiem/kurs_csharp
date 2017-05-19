using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_24
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            string[] arr = s.Split();


            HashSet<int> rng = new HashSet<int>();

            for (int i = 0; i < arr.Length; i++)
            {
                int x = int.Parse(arr[i]);
                rng.Add(x);
            }

            Console.WriteLine(rng.Count);
        }
    }
}
