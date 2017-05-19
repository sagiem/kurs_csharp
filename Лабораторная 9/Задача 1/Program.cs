using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Задача_1
{
    class Program
    {
        static void Main(string[] args)

        {

            Console.WriteLine("Введите номер теста");
            string index = Console.ReadLine();
            string filename = "test" + index + ".txt";
            int i = 0;

            if(! File.Exists(filename))
            {
                Console.WriteLine("Сообщение об ошибке");
                return;
            }

            StreamReader reader = new StreamReader(filename);

            if(!reader.EndOfStream)
            {
                Console.Write(reader.ReadLine());
            }
           
            while(!reader.EndOfStream)
            {
                Console.Write(", " + reader.ReadLine());
                i++;

            }
            Console.WriteLine();
            Console.WriteLine(" i="+i);
            reader.Close();
        }
    }
}
