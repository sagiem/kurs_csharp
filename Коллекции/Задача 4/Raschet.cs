﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_4
{
    class Raschet
    {
        List<Points> rng = new List<Points>();


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

            for (int i = 0; i < rng.Count(); i++)
            {
                Points item = rng[i];
                
                if(item.x==x&&item.y==y)
                {
                    m++;
                }
            }

            if (m == 0)
            {
                Points Rec = new Points(x, y, w);
                rng.Add(Rec);
                m = 0;
            }

        }

        public void print()
        {


            for (int i = 0; i < rng.Count(); i++)
            {
                Points item = rng[i];
                Console.WriteLine("{\"x\":"+item.x+ ", \"y\":"+item.y+ ", \"color\":\""+item.color+"\"}");
            }
        }
    }
}
