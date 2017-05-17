using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_15
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            string[] arr = s.Split();
            int x = 0;

            for(int i = 0; i<arr.Length;i++)
            {
                for(int l = i+1; l<arr.Length;l++)
                {
                    if(arr[i]==arr[l])
                    {
                        x++;
                    }
                }
            }

            if(x!=0)
            {
                Console.WriteLine("Повторения есть");
            }

            else
            {
                Console.WriteLine("Повторений нет ");
            }



        }
    }
}
