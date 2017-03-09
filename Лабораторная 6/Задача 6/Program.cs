using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int kg = 1;
            int fn;

            while(kg<10)
            {
                fn = kg * 453;
                Console.WriteLine("{0}      {1}", kg, fn);
                kg = kg + 1;

            }

            while (kg <= 20)
            {
                fn = kg * 453;
                Console.WriteLine("{0}     {1}", kg, fn);
                kg = kg + 1;

            }
        }
    }
}
