using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_20
{
    class Program
    {
        static void Main(string[] args)
        {
            double Xt, Yt, Xn, Yn, H, W;

            Console.WriteLine("Введите Xt");
            Xt = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите Yt");
            Yt = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите Xn");
            Xn = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите Yn");
            Yn = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите H");
            H = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите W");
            W = double.Parse(Console.ReadLine());

            if(Xt<0||Yt<0||Xn<0||Yn<0||H<=0||W<=0)
            {
                Console.WriteLine("Сообщеие об ошибке");
                return;
            }

            if(Xt>Xn&&Yt>Yn&&Xt<H&&Xt<W&&Yt<H&&Yt<W)
            {
                Console.WriteLine("точка внутри");
            }
            else
            {
                Console.WriteLine("точка не внутри");
            }

        }
    }
}
