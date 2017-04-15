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
            Console.WriteLine();

            int[] in8878a = { 5, 11, -2, -13 };
            int[] in8878b = { 6, 7, 3, -18 };
            for (int i = 0; i < in8878a.Length; i++)
            {
                if (task8878(in8878a[i], in8878b[i]))
                {
                    Console.WriteLine("Второе");
                }
                else
                {
                    Console.WriteLine("Первое");
                }
            }

            Console.WriteLine("task8715");

            int[] in8718a = { 1, -4, 7, 0, 4, -2, 10, 5 };
            int[] in8718b = { 2, 0, 4, 5, 4, 4, 3, 1 };
            int[] in8718c = { 3, 5, -2, -7, 4, 3, 5, 7 };
            for (int i = 0; i < in8718a.Length; i++)
            {
                if (task8715(in8718a[i], in8718b[i], in8718c[i]))
                {
                    Console.WriteLine("Выполняется");
                }
                else
                {
                    Console.WriteLine("Не выполняется");
                }
            }
        }

        static bool task8878(int a, int b)
        {
            bool r;
            r = b > a;
            return r;
        }

        static bool task8715(int a, int b, int c)
        {
            
            return a < b && b < c;
            
        }
    }
}
