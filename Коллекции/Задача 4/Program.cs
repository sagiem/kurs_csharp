using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите номер теста");
            string a = Console.ReadLine();
            string filename = "test" + a + ".csv";
            Raschetset r = new Raschetset();

            try
            {
                ProcessFile(filename, r);
                r.print();
                //Console.WriteLine(r.Print());
            }
            catch (ArgumentException ex)
            {
                //Console.Write("действий:{0} ", r.m);
                Console.WriteLine(ex.Message);
            }
        }

        public static void ProcessFile(string filename, Raschetset r)
        {
            if (!File.Exists(filename))
            {
                throw new ArgumentException("Файл не существует");
            }

            StreamReader reader = new StreamReader(filename);
            while (!reader.EndOfStream)
            {
                string row = (reader.ReadLine());
                r.Selectaction(row);

            }
        }
    }
}
