using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_7
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

            if (!File.Exists(filename))
            {
                Exception e = new Exception("Файл не существует");
                throw e;
            }

            StreamReader reader = new StreamReader(filename);




            List<int> lst = new List<int>();

            while (!reader.EndOfStream)
            {
                string s = reader.ReadLine();
                string[] arr= s.Split(',');
                for(int i = 0; i < arr.Length; i++)
                {
                    int x = int.Parse(arr[i]);
                    

                }
            }

            reader.Close();


            foreach(string item in arr)
            {

            }
        }
    }
}
