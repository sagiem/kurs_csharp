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
            int[] array = new int[arr.Length];

            for(int l=0;l<arr.Length; l++)
            {
                array[l] = int.Parse(arr[l]);
            }


            


            bool changed = true;

            while (changed)
            {
                changed = false;

                for (int i = 0; i < array.Length - 1; i++)
                    if (array[i] > array[i + 1])
                    {
                        int tmp = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = tmp;
                        changed = true;
                    }
            }



            foreach (int item in array)
            {
                Console.Write(item + " ");
            }


        }
    }
}
