using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_17
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

            int[] arr1 = new int[arr.Length];
 
            for(int i=0;i<arr.Length;i++)
            {
                arr1[i] = int.Parse(arr[i]) - x;
                Console.Write(arr1[i] + " ");

            }

            
        }
    }
}
