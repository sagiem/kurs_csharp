using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_2
{
    class Point
    {
        public int x;
        public int y;

        public double DistanceTo(Point m)
        {
            if(m==null)
            {
                throw new ArgumentException("Конечная точка не инициализирована");
            }

            int dx = m.x - this.x;
            int dy = m.y - this.y;
            return Math.Sqrt(dx * dx + dy * dy);

        }
    }
}
