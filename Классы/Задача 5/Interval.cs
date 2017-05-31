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

        public bool Intersects(Interval m)
        {
            if (m == null)
            {
                throw new ArgumentException("Данный интервал не инициализирован");
            }


            bool zz = false;
            int A1 = this.a;
            int B1 = this.b;
            int A2 = m.a;
            int B2 = m.b;


            if (A1 > B1 || A2 > B2)
            {
                throw new ArgumentException("Некорректный интервал");
            }

            if (A2 > A1 && A2 < B1)
            {
                if (B1 > A2 && B1 < B2)
                {

                    return zz = true;
                }

                if (B2 > A1 && B2 < B1)
                {

                    return zz = true;
                }
            }

            if (A1 > A2 && A1 < B2 && B2 > A1 && B2 < B1)
            {

                return zz = true;
            }

            if (A1 > A2 && A1 < B2 && B1 > A2 && B1 < B2)
            {

                return zz = true;
            }

            return zz;

        }

        public static bool AreIntersect(Interval m, Interval l)
        {
            if (m == null)
            {
                throw new ArgumentException("Данный интервал не инициализирован");
            }


            bool zz = false;
            int A1 = l.a;
            int B1 = l.b;
            int A2 = m.a;
            int B2 = m.b;


            if (A1 > B1 || A2 > B2)
            {
                throw new ArgumentException("Некорректный интервал");
            }

            if (A2 > A1 && A2 < B1)
            {
                if (B1 > A2 && B1 < B2)
                {

                    return zz = true;
                }

                if (B2 > A1 && B2 < B1)
                {

                    return zz = true;
                }
            }

            if (A1 > A2 && A1 < B2 && B2 > A1 && B2 < B1)
            {

                return zz = true;
            }

            if (A1 > A2 && A1 < B2 && B1 > A2 && B1 < B2)
            {

                return zz = true;
            }

            return zz;

        }

    }
}
