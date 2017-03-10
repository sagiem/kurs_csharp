using System;
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
            string a = s.Replace("\"", "");
            Console.WriteLine(a.Trim());
        }
    }
}
