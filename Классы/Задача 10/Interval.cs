using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_10
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

        public void Slide(int x)
        {
            if (a > b)
            {
                throw new ArgumentException("Некорректный интервал");
            }

            this.a = this.a + x;
            this.b = this.b + x;
        }

        public void Squeeze(int x)
        {
            if (a > b)
            {
                throw new ArgumentException("Некорректный интервал");
            }

            if((this.b-this.a)<x)
            {
                throw new ArgumentException("Невозможно уменьшить интервал на указанную длину");
            }

            this.b = this.b - x;

        }
    }
}
