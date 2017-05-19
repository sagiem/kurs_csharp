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

            Console.WriteLine("task8174");
            Console.WriteLine(task8174(-5) - 5);
            Console.WriteLine(task8174(-11) - 11);
            Console.WriteLine(task8174(7) - 7);
            Console.WriteLine(task8174(13) - 13);
            Console.WriteLine(task8174(0));

            Console.WriteLine("task5662");
            Console.WriteLine(task5662(1, 2, 3));
            Console.WriteLine(task5662(3, 17, 5));
            Console.WriteLine(task5662(3, 6, 3));
            Console.WriteLine(task5662(0, 7, 13));

            Console.WriteLine("task3770");
            Console.WriteLine(task3770(1, 2, 3) - 3);
            Console.WriteLine(task3770(7, 4, -2) - 7);
            Console.WriteLine(task3770(0, 5, -7) - 5);

            Console.WriteLine("task2475");
            Console.WriteLine(task2475() - 120300);

            Console.WriteLine("task9562");
            Console.WriteLine(task9562(15, 27) - 273);
            Console.WriteLine(task9562(25, 44) - 690);
            Console.WriteLine(task9562(80, 100) - 1890);
            Console.WriteLine(task9562(3000, 24) - 4501224);

            Console.WriteLine("task3669");
            Console.WriteLine(task3669(8, 13) - 1235520);
            Console.WriteLine(task3669(159, 161) - 4095840);
            Console.WriteLine(task3669(648, 648) - 648);
            Console.WriteLine(task3669(-2, 600));
            Console.WriteLine(task3669(50, 24) - 2421409269157986304L);

            Console.WriteLine("task5951");
            Console.WriteLine(task5951() - 630);

            Console.WriteLine("task6580");
            Console.WriteLine(task6580(15, 27) - 5915);
            Console.WriteLine(task6580(25, 44) - 24470);
            Console.WriteLine(task6580(80, 100) - 170870);
            Console.WriteLine(task6580(3000, 24) - 414561584);

            Console.WriteLine("task5969");
            Console.WriteLine(task5969(8, 13));
            Console.WriteLine(task5969(25, 44) - 105);
            Console.WriteLine(task5969(80, 100) - 273);
            Console.WriteLine(task5969(300, 24) - 6279);

            Console.WriteLine("task8696");
            Console.WriteLine(task8696() - 69);

            Console.WriteLine("task4265");
            Console.WriteLine(task4265("sABCD"));
            Console.WriteLine(task4265("Uxyz"));
            Console.WriteLine(task4265("s"));
            Console.WriteLine(task4265("F123"));
            Console.WriteLine(task4265("Sopqr"));

            Console.WriteLine("task9925");
            int result9925 = task9925("один, два, три, четыре, пять");
            Console.WriteLine(result9925 - 5);
            Console.WriteLine(task9925("янв,фев,март") - 3);
            Console.WriteLine(task9925("один") - 1);

            Console.WriteLine("task3946");
            String[] in3946 = { "1 2 3 4 1", "1 2 3 4 1 3 4 4 4 4"};
            double[] out3946 = { 2.2, 3, 0 };
            for (int i = 0; i < in3946.Length; i++)
            {
                double result = task3946(in3946[i]);
                Console.WriteLine("{0:F6} ({0:F6})", result, out3946[i]);
            }

            Console.WriteLine("task7035");
            String[] in7035 = {"1 2 3 4 5 6","3 4 1 2 3 4 1 2 3 1 2","4 2 3 4 3 2","4 4 4 4 4 3 8 9","4 4 4 4","4 3"};
            int[] out7035 = { 1, 1, 2, 3, 4, 3 };
            for (int i = 0; i < in7035.Length; i++)
            {
                int result = task7035(in7035[i]);
                Console.WriteLine("{0} ({1})", result, out7035[i]);
            }

            Console.WriteLine("task4283");
            int[] in4283k = { 3, 5, 2, 1 };
            String[] in4283s = {"1 2 3 4 1 2","1 2 3 4 1 2 3 4 1 2 3","3 2 2 2 2 2","4 4 4 4 4 4"};
            int[] out4283 = { 1, 0, 5, 0 };
            for (int i = 0; i < in4283k.Length; i++)
            {
                int result = task4283(in4283k[i], in4283s[i]);
                Console.WriteLine("{0} ({1})", result, out4283[i]);
            }

            Console.WriteLine("task9182");
            String[] in9182 = {"1 2 3 4 5 6","1 2 3 1 2 6","1 1 1 1 1 1"};
            int[] out9182 = { 6, 4, 1 };
            for (int i = 0; i < out9182.Length; i++)
            {
                int result = task9182(in9182[i]);
                Console.WriteLine("{0} ({1})", result, out9182[i]);
            }

        }







        static double task4411(double a)
        {
            return 2 * a;
        }

        static int task3832(int x1, int x2, int x3)
        {
            return x1 * x2 + x1 * x3 + x2 * x3;
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

        static double task4366(double x1, double x2)
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
            if (a > 0)
            {
                a = Math.Sqrt(a);
            }

            else
            {
                a = a * a;
            }

            return a;

        }

        static double task8174(double a)
        {
            if (a < 0)
            {
                a = a * (-1);
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

            if (a == 0)
            {
                return "Данное уравнение не является квадратным";
            }

            if (d > 0)
            {
                return string.Format("У уравнения {0}x^2 + {1}x + {2} = 0 два вещественных корня", a, b, c);
            }



            if (d < 0)
            {
                return string.Format("Вещественных корней уравнения {0}x^2 + {1}x + {2} = 0 нет", a, b, c);
            }

            return string.Format("Уравнение {0}x^2 + {1}x + {2} = 0 имеет один корень", a, b, c);


        }

        static double task3770(double x, double y, double z)
        {
            double q = 0;

            if (x > y && x > z)
            {
                q = x;
            }

            if (y > x && y > z)
            {
                q = y;
            }

            if (z > x && z > y)
            {
                q = z;
            }

            return q;
        }

        static int task2475()
        {
            int n = 100;
            int a = 0;

            while (n <= 500)
            {
                a = a + n;
                n++;
            }

            return a;
        }

        static int task9562(int a, int b)
        {
            int s = 0;


            if (b < a)
            {
                while (b <= a)
                {
                    s = b + s;
                    b++;
                }
            }


            else
            {
                while (a <= b)
                {
                    s = a + s;
                    a++;
                }
            }
            return s;
        }

        static int task5951()
        {
            int a = 20;
            int b = 40;
            int s = 0;

            while (a <= b)
            {
                s = a * a * a + s;
                a++;
            }

            return s;

        }

        static int task6580(int a, int b)
        {
            int s = 0;

            if (b < a)
            {
                while (b <= a)
                {
                    s = b * b + s;
                    b++;
                }
            }


            else
            {
                while (a <= b)
                {
                    s = a * a + s;
                    a++;
                }
            }

            return s;
        }

        static int task5969(int a, int b)
        {
            int s = 0;

            if (b < a)
            {
                b = b - 1;
                while (b < a)
                {
                    b++;
                    if (b % 7 == 0)
                    {
                        s = s + b;
                    }
                }
            }

            if (a < b)
            {
                a = a - 1;
                while (a < b)
                {
                    a++;
                    if (a % 7 == 0)
                    {
                        s = s + a;
                    }                   
                }
            }

            return s;
        }

        static int task8696()
        {
            int a = 100, b = 1000;
            int s = 0;
            int i = 0;



            a = a - 1;
            while (a < b)
            {
                a++;


                if (a % 13 == 0)
                {
                    s++;
                }

            }

            return s;
        }

        static string task4265(string s)
        {
            
            if (s.StartsWith("s"))
            {
                return s=s.ToLower();
            }
            else
                if (s.StartsWith("U"))
                {
                    return s=s.ToUpper();
                }

            return s;
        }

        static int task9925(string s)
        {
            string[] arr = s.Split(',');
            return arr.Length;
        }

        static double task3946(string a)
        {
            string[] arr = a.Split();
            double b = 0;

            for (int i = 0; i < arr.Length; i++ )
            {
                double s = double.Parse(arr[i]);
                b = b + s;
                
            }

            return b / arr.Length;
        }

        static int task7035(string s)
        {
            string[] arr = s.Split();
            int x = int.Parse(arr[0]);

            for (int i = 1; i < arr.Length; i++)
            {

                int a = int.Parse(arr[i]);

                if (a < x)
                {
                    x = a;
                }

            }

            return x;
        }

        static int task4283(int k, string s)
        {
           
            string[] arr = s.Split();
            int m = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                int x = int.Parse(arr[i]);
                if (k == x)
                {
                    m++;
                }
            }

            return m;
        }

        static int task9182(string s)
        {
            
            string[] arr = s.Split();


            HashSet<int> rng = new HashSet<int>();

            for (int i = 0; i < arr.Length; i++)
            {
                int x = int.Parse(arr[i]);
                rng.Add(x);
            }

            return rng.Count;
        }
    }

}


