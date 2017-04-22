using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("task9298");
            int[] in9298 = { 1, 5, 0, -2 };
            int[] outs9298 = { 6, 150, 0, 0 };
            for (int i = 0; i < in9298.Length; i++)
            {
                try
                {
                    int result = task9298(in9298[i]);
                    Console.WriteLine("{0} ({1})", result, outs9298[i]);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }

            Console.WriteLine("task3354");
            int[] in3354 = { 7, 11, 0, -3 };
            int[] outs3354 = { 343, 1331, 0, 0 };
            for (int i = 0; i < in3354.Length; i++)
            {
                try
                {
                    int result = task3354(in3354[i]);
                    Console.WriteLine("{0} ({1})", result, outs3354[i]);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }

            Console.WriteLine("task5201");
            int[] in5201 = { 13, 17, 0, -5 };
            double[] outs5201 = { 81.6814, 106.8142, 0, 0 };
            for (int i = 0; i < in5201.Length; i++)
            {
                try
                {
                    double r = task5201(in5201[i]);
                    Console.WriteLine("{0:F6} ({1:F6})", r, outs5201[i]);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }


        }

        static int  task9298(int a)
        {
            if(a<=0)
            {
                Exception e = new Exception("Значание А должно быть положительным");
                throw e;
            }

            return 6 * a * a;
        }

        static int task3354(int a)
        {
            if(a<=0)
            {
                Exception e = new Exception("Значание А должно быть положительным");
                throw e;
            }

            return a * a * a;
        }

        static double task5201(int R)
        {
            if(R<=0)
            {
                Exception e = new Exception("Значание R должно быть положительным");
                throw e;
            }

            return 2 * R * Math.PI;
        }
    }
}
