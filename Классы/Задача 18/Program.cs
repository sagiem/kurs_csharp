using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите номер теста");
            string a = Console.ReadLine();
            string filename = "test" + a + ".csv";
            Raschet r = new Raschet();

            try
            {
                ProcessFile(filename, r);
                Console.WriteLine(r.Print());
            }
            catch (ArgumentException ex)
            {
                Console.Write("действий:{0} ", r.m);
                Console.WriteLine(ex.Message);
            }
        }

        public static void ProcessFile(string filename, Raschet r)
        {
            if (!File.Exists(filename))
            {
                throw new ArgumentException("Файл не существует");
            }

            StreamReader reader = new StreamReader(filename);
            while (!reader.EndOfStream)
            {
                string row = (reader.ReadLine());
                string[] arr = row.Split(';');

                if (arr.Length != 2)
                {
                    throw new ArgumentException("Некорректный формат");
                }
                int k = int.Parse(arr[1]);
                r.Selectaction(arr[0], k);
            }
        }
    }
}
