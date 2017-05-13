using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> lst = new List<int>();
            lst.Add(17);
            lst.Add(19);
            lst.Add(23);
            lst.Insert(0, 29);
            lst.Remove(18);
            System.Console.WriteLine(lst.Count); 
            Console.WriteLine(lst[0]);
            Console.WriteLine(string.Join(";", lst));
            SortedList<Int32,String> sort = new SortedList<Int32, String>();
            sort.Add(23, "a");
            sort.Add(19, "b");
            Console.WriteLine(String.Join(" ", sort));

            for(int i=0; i<lst.Count; i++)
            {
                int item = lst[i];
                Console.WriteLine(item);
            }

            foreach (int item in lst)
            {
                Console.WriteLine(item);
                
            }
            Console.WriteLine();
            Console.WriteLine();

            HashSet<int> rng = new HashSet<int>();
            rng.Add(17);
            rng.Add(19);
            rng.Add(17);

            foreach(int item in rng)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(rng.Count);

            //for (int i = 0; i < rng.Count; i++)
            //{
            //    int item = rng[i];
            //    Console.WriteLine(item);
            //}
        }
    }
}
