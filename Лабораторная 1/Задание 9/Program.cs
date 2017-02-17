using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_9
{
    class Program
    {
        static void Main(string[] args)
        {
            string id;

            Console.WriteLine("Введите значение id");
            id = Console.ReadLine();
            Console.WriteLine("SELECT first_name, last_name, group FROM students WHERE student_id = '{0}';", id);
            


        }
    }
}
