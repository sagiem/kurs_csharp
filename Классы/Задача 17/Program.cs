using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите номер теста");
            Raschet r = new Raschet();

            try
            {
                
                r.nachalo(Console.ReadLine());
                Console.Write("действий:{0} ",r.m);
                Console.WriteLine("{\"x\":" + r.x + ",\"y\":" + r.y + ",\"w\":" + r.width + ",\"h\":" + r.height + "}");
 
            }

            catch (ArgumentException ex)
            {
                Console.Write("действий:{0} ", r.m);
                Console.WriteLine(ex.Message);
            }

            


        }
    }
}
