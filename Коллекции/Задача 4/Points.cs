using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_4
{
    class Points
    {
        public int x = 0;
        public int y = 0;
        public string color;

        public Points(int x,int y,string color)
        {
            this.x = x;
            this.y = y;
            this.color = color;
        }

        // override object.Equals
        public override bool Equals(object obj)
        {
            //       
            // See the full list of guidelines at
            //   http://go.microsoft.com/fwlink/?LinkID=85237  
            // and also the guidance for operator== at
            //   http://go.microsoft.com/fwlink/?LinkId=85238
            //

            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            // TODO: write your implementation of Equals() here
            Points o = (Points)obj;
            if (this.x == o.x && this.y == o.y)        // return this.x==o.x&&this.y==o.y;
            {
                return true;
            }
            return false;
        }

        // override object.GetHashCode
        public override int GetHashCode()
        {
            // TODO: write your implementation of GetHashCode() here

            return x ^ y;
        }
    }
}
