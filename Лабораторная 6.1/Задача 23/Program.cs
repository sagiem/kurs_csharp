using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_23
{
    class Program
    {
        static void Main(string[] args)
        {

            string s = Console.ReadLine();
            string[] arr = s.Split();
            int[] arr1 = new int[arr.Length];
            int m = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                int x = int.Parse(arr[i]);
                for (int l = 0; l < arr.Length; l++)
                {
                    if(x!=arr1[l])
                    {
                        m = x;
                    }

                }

                arr1[i] = x;
                m = 0;

              

            }

            foreach (int item in arr1)
            {
                Console.Write(item + " ");
            }
        }
    }
}
