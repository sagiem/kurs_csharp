using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_4
{
    class Raschetset
    {
        HashSet<Points> rng = new HashSet<Points>();


        public void Selectaction(string line)
        {
            string[] arr = line.Split(';');


            if (arr.Length != 3)
            {
                throw new ArgumentException("Некорректный формат");
            }

            int m = 0;
            int x = int.Parse(arr[0]);
            int y = int.Parse(arr[1]);
            string w = arr[2];
            Points point = new Points(x, y, w);
            if (rng.Contains(point) == false)
            {
                Points Rec = new Points(x, y, w);
                rng.Add(Rec);

            }

        }

        public void print()
        {
            foreach (Points items in rng)
            {
                Console.WriteLine("{\"x\":" + items.x + ", \"y\":" + items.y + ", \"color\":\"" + items.color + "\"}");
            }
        }
    }
}

