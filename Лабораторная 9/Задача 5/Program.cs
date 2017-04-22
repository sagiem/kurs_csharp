using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Задача_5
{
    class Program
    {
        static void Main(string[] args)
        {

            string filename;

            

            Console.WriteLine("Введите номер теста");
           filename = "test"+Console.ReadLine()+".txt";

            try
            {
                using (StreamReader reader = new StreamReader(filename))
                {

                    int r = task5537(reader);
                    Console.WriteLine(r);
                }

                
            }

            catch(FormatException)
            {
                Console.WriteLine("Некорректное число");
            }
   

            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
        }

        static int task5537(StreamReader reader)
        {
            int m = 0;

            while (!reader.EndOfStream)
            {
                string b = reader.ReadLine();

                int l = int.Parse(b);

                if(l<1000||l>9999)
                {
                    Exception e = new Exception("Значение А вне диапазона от 1000 до 9999");
                    throw e;
                }

                char[] arr = b.ToCharArray();
                char v = arr[0];
                char x = arr[1];
                char c = arr[2];
                char z = arr[3];

                

                if (v == x || x == c || c == z)
                {
                    m++;
                }

            }

            return m;
        }




    }
}
