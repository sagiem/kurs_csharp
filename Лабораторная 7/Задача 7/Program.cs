using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_7
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "abcdacadbacdaabaadc";
            string a = Console.ReadLine();

            if (s.IndexOf(a) < 0||a.Length >2)
            {
                Console.WriteLine("Сообщение об ошибке");
                return;
            }

            Console.WriteLine(s.Replace(a, " "));
        }
    }
}
