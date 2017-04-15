using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_2
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("task4411");
            Console.WriteLine(task4411(11.13) - 22.26);
            Console.WriteLine(task4411(-7919) - -15838);
            Console.WriteLine(task4411(0) - 0);


            Console.WriteLine("task3832");
            Console.WriteLine(task3832(7451, 7433, 7417) - 165777911);
            Console.WriteLine(task3832(3, 7, 11) - 131);
            Console.WriteLine(task3832(-2, -2029, 0) - 4058);


            Console.WriteLine("task3669");
            Console.WriteLine(task3669(8, 13) - 1235520);
            Console.WriteLine(task3669(159, 161) - 4095840);
            Console.WriteLine(task3669(648, 648) - 648);
            Console.WriteLine(task3669(-2, 600));
            Console.WriteLine(task3669(50, 24) - 2421409269157986304L);

            Console.WriteLine("task5662");
            Console.WriteLine(task5662(1, 2, 3));
            Console.WriteLine(task5662(3, 17, 5));
            Console.WriteLine(task5662(3, 6, 3));
            Console.WriteLine(task5662(0, 7, 13));
        }

        static double task4411(double a)
        {
            return 2 * a;
        }

        static int task3832(int x1, int x2, int x3)
        {
            return x1*x2 + x1*x3 + x2*x3;
        }

        static long task3669(long a, long b)
        {
            if (a > b)
            {
                long c;
                c = a;
                a = b;
                b = c;
            }

        


            long s = 1;

            while (a <= b)
            {
                s = a * s;
                a++;
            }
            return s;

        }

        static string task5662(int a, int b, int c)
        {
            int d = b * b - 4 * a * c;

            if(a==0)
            {
                return "Данное уравнение не является квадратным";
            }

            if(d>0)
            {
                return string.Format("У уравнения {0}x^2 + {1}x + {2} = 0 два вещественных корня", a,b,c);
            }

         

            if(d<0)
            {
                return string.Format("Вещественных корней уравнения {0}x^2 + {1}x + {2} = 0 нет",a,b,c);
            }

            return string.Format("Уравнение {0}x^2 + {1}x + {2} = 0 имеет один корень",a,b,c);

            
        }



        
    }
}
