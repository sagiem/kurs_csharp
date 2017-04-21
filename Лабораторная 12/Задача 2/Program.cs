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

            Console.WriteLine("task8428");
            Console.WriteLine("{0:F6}", task8428(45) - 0.7854);
            Console.WriteLine("{0:F6}", task8428(1125) - 19.6350);
            Console.WriteLine("{0:F6}", task8428(0));
            Console.WriteLine("{0:F6}", task8428(360) - 6.2832);
            Console.WriteLine("{0:F6}", task8428(90) - 1.5708);
            Console.WriteLine("{0:F6}", task8428(2000) - 34.9066);

            Console.WriteLine("task5063");
            Console.WriteLine(task5063(365) - 5);
            Console.WriteLine(task5063(45) - 45);
            Console.WriteLine(task5063(1125) - 45);
            Console.WriteLine(task5063(1500) - 60);
            Console.WriteLine(task5063(2000) - 200);
            Console.WriteLine(task5063(0));
            Console.WriteLine(task5063(360));

            Console.WriteLine("task7711");
            Console.WriteLine("{0:F6}", task7711(45) - 0.7071);
            Console.WriteLine("{0:F6}", task7711(1125) - 0.7071);
            Console.WriteLine("{0:F6}", task7711(7639) - 0.9816);
            Console.WriteLine("{0:F6}", task7711(360) - 0.0000);
            Console.WriteLine("{0:F6}", task7711(90) - 1.0000);

            Console.WriteLine("task1262");
            Console.WriteLine("{0:F6}", task1262(7583) - 4.6025);
            Console.WriteLine("{0:F6}", task1262(200) - -4.6985);
            Console.WriteLine("{0:F6}", task1262(360) - 5);
            Console.WriteLine("{0:F6}", task1262(90) - 0);

            Console.WriteLine("task3832");
            Console.WriteLine(task3832(7451, 7433, 7417) - 165777911);
            Console.WriteLine(task3832(3, 7, 11) - 131);
            Console.WriteLine(task3832(-2, -2029, 0) - 4058);

            Console.WriteLine("task1346");
            double result1346 = task1346(7411, 7433, 7417);
            Console.WriteLine("{0:F6}", result1346 - 204947815919.5);
            Console.WriteLine("{0:F6}", task1346(3, 7, 11) - 290.5);

            Console.WriteLine("task7799");
            Console.WriteLine("{0:F6}", task7799(7297, 7283) - 8720.9080);
            Console.WriteLine("{0:F6}", task7799(2659, 0) - 26076.0153);

            Console.WriteLine("task9354");
            Console.WriteLine(task9354(7247, 7243, 7229) - -157093203);
            Console.WriteLine(task9354(7, 1, 3) - -83);

            Console.WriteLine("task5895");
            double result5895 = task5895(7109, 7103, 7079);
            Console.WriteLine("{0:F6}", result5895 - 12369.4955);
            Console.WriteLine("{0:F6}", task5895(3, 7, 13) - 4.1324);

            Console.WriteLine("task2790");
            Console.WriteLine("{0:F6}", task2790(6997) - 0.9205);
            Console.WriteLine("{0:F6}", task2790(31) - 0.8572);
            Console.WriteLine("{0:F6}", task2790(0) - 1.0000);

            Console.WriteLine("task9164");
            Console.WriteLine("{0:F6}", task9164(90, 90) - 0.0);
            Console.WriteLine("{0:F6}", task9164(90, 0) - 1.0);
            Console.WriteLine("{0:F6}", task9164(7559, 7549) - -0.2079);

            Console.WriteLine("task7457");
            Console.WriteLine(task7457(6883) - 331609180);
            Console.WriteLine(task7457(-6871) - 330495106);
            Console.WriteLine(task7457(0) - 6);

            Console.WriteLine("task9865");
            Console.WriteLine("{0:F6}", task9865(6869) - 566245999.0000);
            Console.WriteLine("{0:F6}", task9865(-6863) - 565161171.0000);
            Console.WriteLine("{0:F6}", task9865(0) - -16.0000);
            Console.WriteLine("{0:F6}", task9865(-1.482634) - 0.0000);

            Console.WriteLine("task3558");
            Console.WriteLine("{0:F6}", task3558(45, 90) - 0.0);
            Console.WriteLine("{0:F6}", task3558(200, 45) - -1.3636);
            Console.WriteLine("{0:F6}", task3558(7523, 7517) - 1.8148);

            Console.WriteLine("task4366");
            Console.WriteLine("{0:F6}", task4366(7459, 7457) - 10547.2048);
            Console.WriteLine("{0:F6}", task4366(-3, -7) - 7.6158);
            Console.WriteLine("{0:F6}", task4366(0, 0) - 0.0);

            Console.WriteLine("task5789");
            Console.WriteLine("{0:F6}", task5789(1, 1, 3, 4) - 3.6055);
            Console.WriteLine("{0:F6}", task5789(-2, 4, 8, -10) - 17.2046);
            Console.WriteLine("{0:F6}", task5789(0, 0, -5, -7) - 8.6023);
            Console.WriteLine("{0:F6}", task5789(0, 0, 0, 0) - 0);
            Console.WriteLine("{0:F6}", task5789(-1, -3, 2, 9) - 12.3693);

            Console.WriteLine("task5980");
            Console.WriteLine(task5980(9) - 3.0);
            Console.WriteLine(task5980(0) - 0.0);
            Console.WriteLine(task5980(-7) - 49.0);

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

        static double task8428(double A)
        {
            double B = A * (Math.PI) / 180;
            return B;
        }

        static int task5063(int a)
        {

            int m;
            return m = a % 360;
           
        }

        static double task7711(int a)
    {
            double r = Math.Sin(a * Math.PI / 180);
            return r;
    }
        static double task3832(double x1, double x2, double x3)
        {
            double R = x1 * x2 + x1 * x3 + x2 * x3;
            return R;
        }

        static double task1346(int v0, int t, int a)
        {
            double R = v0 * t + a * t * t / 2; ;

            return R;
        }

        static double task7799(int m, int a)
        {
            double g = 9.8067;
            double R = m * g * Math.Sqrt(a * Math.PI / 180);
            return R;
        }

        static double task9354(int a, int b, int c)
        {
            double R = b * b - 4 * a * c;
            return R;
        }

        static double task5895(int a, int b, int c)
        {
            double R = Math.Sqrt(a * a + b * b - 2 * a * b * Math.Cos(c * Math.PI / 180));
            return R;
        }

        static double task2790(int s)
        {
            double R = Math.Sqrt(1 - Math.Sin(s * Math.PI / 180) * Math.Sin(s * Math.PI / 180));
            return s;
        }

        static double task9164(int a, int b)
        {
            double R = Math.Sin(a) * Math.Cos(b) + Math.Cos(a) * Math.Sin(b);
            return R;
        }

        static double task7457(double x)
        {
            double y = 7 * x * x - 3 * x + 6;
            return y;
        }

        static double task9865(double a)
        {
            double b = 12 * a * a + 7 * a - 16;
            return b;
        }

        static double task3558(int a, int b)
        {
            double R = 3 * (Math.Sin(2 * (a * Math.PI / 180))) * (Math.Cos(3 * (b * Math.PI / 180)));
            return R;
        }

        static double task4366(double x1, double x2 )
        {
            double R = Math.Sqrt(x2 * x2 + x1 * x1);
            return R;
        }

        static double task5789(double Xa, double Ya, double Xb, double Yb)
        {
            double AB = Math.Sqrt((Xb - Xa) * (Xb - Xa) + (Yb - Ya) * (Yb - Ya));
            return AB;
        }

        static double task5980(double a)
        {
            if(a>0)
            {
                a = Math.Sqrt(a);
            }

            else
            {
                a = a * a;
            }

            return a;

        }



        static double task1262(int a)
        {
            double r = 5 * Math.Cos((a * Math.PI / 180));
            return r;
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
