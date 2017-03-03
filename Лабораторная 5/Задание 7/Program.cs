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

            double R, A;

            Console.WriteLine("Введите R");
            R = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите A");
            A = double.Parse(Console.ReadLine());

            if (R <= 0 || A <= 0)
            {
                Console.WriteLine("Сообщение об ошибке");
                return;
            }

            R = Math.PI * R * R;
            A = A * A;

       

            if(A>R)
            {
                Console.WriteLine("Площадь квадрата больше площади круга");
            }

            else
            {
                Console.WriteLine("Площадь круга больше площади квадрата");
            }

        }
    }
}
