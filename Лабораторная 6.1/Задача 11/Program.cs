using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_11
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            string[] arr = s.Split();
            string[] arr1 = new string[arr.Length];
            int x= arr.Length-1;

            for(int i=0; i<arr.Length; i++)
            {

                arr1[i] = arr[x];
                x--;       
            }

            foreach(string item in arr1)
            {
                Console.WriteLine(item);
            }
        }
    }
}
