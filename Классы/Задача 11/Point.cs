using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_11
{
    class Point
    {
        public int x;
        public int y;

        public string Print()
        {
            return String.Format("({0}:{1})", this.x, this.y);
        }

        public void SetCoordinates(int x1, int y1)
        {
            this.x = x1;
            this.y = y1;
        }

        public double DistanceTo(int x2, int y2)
        {
            int dx = x2 - x;
            int dy = y2 - y;
            return Math.Sqrt(dx * dx + dy * dy);
        }

        public double DistanceTo(Point m)
        {
            if (m == null)
            {
                throw new ArgumentException("Конечная точка не инициализирована");
            }

            int dx = m.x - this.x;
            int dy = m.y - this.y;
            return Math.Sqrt(dx * dx + dy * dy);
        }
    }
}
