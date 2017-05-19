using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Задача_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите номер теста");
            string index = Console.ReadLine();

            try
            {
                int m = mymet(index);
                Console.WriteLine(m);
            }

            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }

        static int mymet(string index)
        {
            string filename = "test" + index + ".txt";

            //if (!File.Exists(filename))
            //{
            //    Exception e = new Exception("Файл не существует");
            //    throw e;
            //}

            StreamReader reader = new StreamReader(filename);

            //if (!reader.EndOfStream)
            //{
            //    Exception e = new Exception("Не удается считать число");
            //    throw e;
            //}

            //if (File.Exists(filename))
            //{
            //    Exception e = new Exception("Файл пуст");
            //    throw e;
            //}


            List<int> lst = new List<int>();

            while (!reader.EndOfStream)
            {
                int x = int.Parse(reader.ReadLine());
                lst.Add(x);
            }

            reader.Close();


            return lst.Min();
        }

    }

    
    

    
}
