using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_9
{
    class Program
    {
        static void Main(string[] args)
        {
            double Sc, Ss;

            Console.WriteLine("Введите Sc");
            Sc = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите Ss");
            Ss = double.Parse(Console.ReadLine());


            Sc = 2 * (Math.Sqrt(Sc * Math.PI)); //сомнительно
            Ss = Math.Sqrt(Ss);

            if(Sc<=0||Ss<=0)
            {
                Console.WriteLine("Сообщение об ошибке");
            }

            if(Sc>Ss)
            {
                Console.WriteLine("Круг не поместится в квадрате");
            }

            else
            {
                Console.WriteLine("Круг уместится в квадрате");
            }



        }
    }
}
