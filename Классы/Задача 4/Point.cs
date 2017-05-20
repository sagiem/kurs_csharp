using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_4
{
    class Point
    {
        public int x;
        public int y;

        public static double DistanceBetween(Point p1, Point p2)
        {
            int dx = p1.x - p2.x;
            int dy = p1.y - p2.y;
            return Math.Sqrt(dx * dx + dy * dy);
        }
    }
}
