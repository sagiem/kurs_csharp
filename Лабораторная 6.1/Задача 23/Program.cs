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
            

            HashSet<int> rng = new HashSet<int>();

            for(int i = 0; i< arr.Length; i++)
            {
                int x = int.Parse(arr[i]);
                rng.Add(x);
            }

            int[] arr1 = new int[rng.Count];
            rng.CopyTo(arr1);

            foreach (int item in arr1)
            {
                Console.Write(item + " ");
            }

            
          

            //for (int i = 1; i < arr.Length; i++)
            //{
            //    int x = int.Parse(arr[i]);
            //    for (int l = 0; l < arr.Length; l++)
            //    {
                    

            //        if (x == arr1[l])
            //        {
            //            m++;
            //        }

            //    }

            //    if (m == 0)
            //    {
            //        arr1[i] = x;
            //    }
            //    else
            //    {
            //        arr[i] = null;
            //    }
            //    m = 0; 

            //}

            //for (int k = 0; k < arr1.Length; k++ )
            //{
            //    if(arr1[k]!=null)
            //    {
            //        p++;
            //    }
            //}

            //int[] arr2 = new int[p];

            //for (int z = 0; z < arr1.Length; z++)
            //{
            //    if (arr1[z] != null)
            //    {
            //        arr2[z]=arr1[z];
            //    }
            //}


            //    foreach (int item in arr2)
            //    {
            //        Console.Write(item + " ");
            //    }
        }
    }
}
