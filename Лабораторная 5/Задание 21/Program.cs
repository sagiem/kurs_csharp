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
            double Xt, Yt, Xn1, Yn1, Xn2, Yn2;

            Console.WriteLine("Введите Xt");
            Xt = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите Yt");
            Yt = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите Xn1");
            Xn1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите Yn1");
            Yn1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите Xn2");
            Xn2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите Yn2");
            Yn2 = double.Parse(Console.ReadLine());

            if(Xt<0||Yt<0||Xn1<0||Yn1<0||Xn2<0||Yn2<0)
            {
                Console.WriteLine("Сообщение об ошибке");
                return;
            }

            if(((Xt<Xn1&&Xt>Xn2)||(Xt>Xn1&&Xt<Xn2))&&((Yt<Yn1&&Yt>Yn2)||(Yt>Yn1&&Yt<Yn2)))
            {
                Console.WriteLine("Точка принадлежит прямой");
            }
            else
            {
                Console.WriteLine("Точка не принадлежит прямой");
            }


        }
    }
}
