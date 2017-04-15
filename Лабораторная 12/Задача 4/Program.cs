using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("task8495");

            StringBuilder sb8495 = new StringBuilder();
            sb8495 = sb8495.Append("@");
            sb8495 = task8495(sb8495);
            sb8495 = sb8495.Append("#");
            Console.WriteLine(sb8495.ToString());

            Console.WriteLine("task1315");

            StringBuilder sb1315 = new StringBuilder();
            sb1315.Append("@");
            task1315(sb1315);
            sb1315.Append("#");
            Console.WriteLine(sb1315);

            Console.WriteLine("task8518");

            String out8518 = "a+\nb\nc\nd\ne\nf\ng\nh\n\n" +
        "a\nb\nc\nd+\ne\nf\ng\nh\n\n" +
        "a\nb\nc\nd\ne\nf\ng\nh+\n\n" +
        "a\nb\nc\nd\ne\nf\ng\nh\n\n";
            StringBuilder sb = new StringBuilder();
            task8518(sb, "a").Append("\n");
            task8518(sb, "d").Append("\n");
            task8518(sb, "h").Append("\n");
            task8518(sb, "i").Append("\n");
            if (out8518.Equals(sb.ToString()))
            {
                Console.WriteLine("Задача решена верно");
            }
            else
            {
                sb.Insert(0, "Неверно. Результат:\n");
                Console.WriteLine(sb.ToString());
            }
        }

        static StringBuilder task8495(StringBuilder sb)
        {
            int i = 0;
            while (i < 13)
            {
                sb.Append("!");
                i++;
            }

            return sb;
        }


        static StringBuilder task1315(StringBuilder sb)
        {
            int a = 17;
            int b = 47;

            while(a<=b)
            {
                sb.Append(a);
                sb.Append(" ");
                    a++;
            }

            return sb;
        }

        static StringBuilder task8518(StringBuilder sb, string b)
        {
                 string[] arr = { "a", "b", "c", "d", "e", "f", "g", "h" };

            
            int n = 0;

            while(n<arr.Length)


            {

                if(b==arr[n])
                {
                    sb.Append(arr[n])
                        .Append("+\n");
                        
                    
                }

                else

                {
                    sb.Append(arr[n])
                        .Append("\n");
                }

                n++;
            }

            return sb;
        }


    }
}
