using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_5
{
    class Interval
    {
        public int a;
        public int b;

        public double Intersects(Interval m)
        {
            if (m == null)
            {
                throw new ArgumentException("Конечная точка не инициализирована");
            }

            int dx = m.a - this.a;
            int dy = m.b - this.b;
            return Math.Sqrt(dx * dx + dy * dy);

        }

        public static double AreIntersect(Interval m, Interval l)
        {
            if (m == null)
            {
                throw new ArgumentException("Конечная точка не инициализирована");
            }

            int dx = m.a - l.a;
            int dy = m.b - l.b;
            return Math.Sqrt(dx * dx + dy * dy);

        }
    }
}
