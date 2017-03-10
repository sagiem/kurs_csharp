using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_6
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            if(s.StartsWith("s"))
            {
                Console.WriteLine(s.ToLower());
            }
            else
            if (s.StartsWith("U"))
            {
                Console.WriteLine(s.ToUpper());
            }
            else
            {
                Console.WriteLine("Сообщение об ошибке");
            }

        }
    }
}
