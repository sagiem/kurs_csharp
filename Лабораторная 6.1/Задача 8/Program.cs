﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_8
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            string[] arr = s.Split();
            string[] arr1 = new string[arr.Length];
            for (int i = 0; i < arr.Length-1; i++)
            {
                arr1[i + 1] = arr[i];
        

            }
            arr1[0] = arr[arr.Length-1];

            foreach (string item in arr1)
            {
                Console.WriteLine(item);
            }
        }
    }
}
