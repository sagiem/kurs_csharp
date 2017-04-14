using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите X");
            string x = Console.ReadLine();
            string s = "a,b,c,d,e,f,g,h";

            string[] arr = { "a", "b", "c", "d", "e", "f", "g", "h" };

            
            int n = 0;

            while(n<arr.Length)


            {

                if(x==arr[n])
                {
                    Console.WriteLine(arr[n]+"+");
                }

                else

                {
                    Console.WriteLine(arr[n]);
                }

                n++;
            }

            

        }
    }
}
