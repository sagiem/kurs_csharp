using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_7
{
    class Interval
    {
        public int a;
        public int b;

        public bool Contains(int x)
         {
            bool m = true;

            if(a>b)
            {
                throw new ArgumentException("Некорректный интервал");
            }

            if(!(x>a&&x<b))
            {
                return m=false;
            }

            return m;
         }
    }
}
