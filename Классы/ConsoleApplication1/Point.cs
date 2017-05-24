using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Point
    {
        public int x;
        public int y;

        public double DistanceTo(int x2, int y2)
        {
            int dx = x2 - x;
            int dy = y2 - y;
            return Math.Sqrt(dx * dx + dy * dy);
        }
    }
}
