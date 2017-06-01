using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_13
{
    class Interval
    {
         private int a;
         private int b;

        public Interval(int a, int b)
        {
            if (a > b)
            {
                throw new ArgumentException("Некорректный интервал");
            }
            this.a = a;
            this.b = b;
        }

        public bool Contains(int x)
        {
            bool m = true;

            if (!(x > a && x < b))
            {
                return m = false;
            }

            return m;
        }

        public string Print()
        {
            return String.Format("[{0}:{1}]", this.a, this.b);
        }

        public void Slide(int x)
        {
            this.a = this.a + x;
            this.b = this.b + x;
        }

        public void Squeeze(int x)
        {
            if ((this.b - this.a) < x)
            {
                throw new ArgumentException("Невозможно уменьшить интервал на указанную длину");
            }

            this.b = this.b - x;
        }

        public int Length()
        {
            return this.b - this.a;
        }
    }

}