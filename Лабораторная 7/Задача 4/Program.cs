using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string a, st = "abcdefwxyz";

            Console.WriteLine("Введите данные");
            a = Console.ReadLine();

            int x = st.IndexOf(a);

            if (x >= 0)
            {
                Console.WriteLine("Содержится");
            }

            else
            {
                Console.WriteLine("Не содержится");

            }


        }
    }
}
