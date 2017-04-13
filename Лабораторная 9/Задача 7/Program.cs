using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Задача_7
{
    class Program
    {
        static void Main(string[] args)
        {

            string filename, c;
            double s = 0;
            double sk = 0;
            double y = 0;

            Console.WriteLine("Введите номер теста");
            int a = int.Parse(Console.ReadLine());

            switch(a)
            {
                case 1:
                    filename = "test1.csv";
                    break;

                case 2:
                    filename = "test2.csv";
                    break;

                case 3:
                    filename = "test3.csv";
                    break;

                case 4:
                    filename = "test4.csv";
                    break;

                case 5:
                    filename = "test5.csv";
                    break;

                default:
                    Console.WriteLine("Сообщение об ошибке");
                    return;
            }

            StreamReader reader = new StreamReader(filename);

            while(!reader.EndOfStream)
            {
                c = reader.ReadLine();
                string[] arr = c.Split(';');
           
           
                    if (arr[0]=="circle")
                    {
                        sk = (Math.PI) * double.Parse(arr[2]) * double.Parse(arr[3]);
                    }

                    if (arr[0]=="rect")
                    {
                        s = double.Parse(arr[3]) * double.Parse(arr[4]);
                    }
                

                if (y < sk) { y = sk; }
             
                if (y < s) { y = s; }
            
            }


            Console.WriteLine("{0:N4}", y);
        }
    }
}
