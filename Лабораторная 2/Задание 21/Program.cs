using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_21
{
    class Program
    {
        static void Main(string[] args)
        {
            double R1, R2, R;
            Console.WriteLine("Введите R1");
            R1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите R2");
            R2 = double.Parse(Console.ReadLine());
            if(R1<=0||R2<=0)
            {
                Console.WriteLine("Сообщение об ошибке");
                return;
            }

            R = (1 / R1) + (1 / R2);
            Console.WriteLine("{0:N4}", R);
            
        }
    }
}
