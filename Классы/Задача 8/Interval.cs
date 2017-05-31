using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_8
{
    class Interval
    {
        public int a;
        public int b;

        public bool Contains(int x)
        {
            bool m = true;

            if (a > b)
            {
                throw new ArgumentException("Некорректный интервал");
            }

            if (!(x > a && x < b))
            {
                return m = false;
            }

            return m;
        }

        public string Print()
        {
            if (a > b)
            {
                throw new ArgumentException("Некорректный интервал");
            }

            return String.Format("[{0}:{1}]", this.a, this.b);
        }
    }
}
