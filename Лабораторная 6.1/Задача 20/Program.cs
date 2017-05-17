using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_20
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string s = Console.ReadLine();
            string[] arr = s.Split();
            int[] arr1 = new int[arr.Length];


            for (int i = 0; i < arr.Length; i++)
            {
                int a = int.Parse(arr[i]);

                for (int l = 1; l < arr.Length; l++)
                {
                    int x = int.Parse(arr[l]);
                    if (a < x)
                    {
                        arr1[i] = a;
                    }
                }
            }

            foreach(int item in arr1)
            {
                Console.Write(item+" ");
            }

           
        }
    }
}
