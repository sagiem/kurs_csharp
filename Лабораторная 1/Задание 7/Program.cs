using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_7
{
    class Program
    {
        static void Main(string[] args)
        {
            double a;
            string message;
            message = Console.ReadLine();
            a = Double.Parse(message);// преобразование текста в число
            Console.WriteLine("{0:N4}", a);

        }
    }
}
