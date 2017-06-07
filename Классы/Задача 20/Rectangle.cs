using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_20
{
    class Rectangle
    {
        private int x = 0;
        private int y = 0;
        private int w = 0;
        private int h = 0;
        private int m = 0;

        public Rectangle(int x, int y, int w, int h)
        {
            this.x = x;
            this.y = y;
            this.w = w;
            this.h = h;
        }



        public void shiftX(int a)
        {
            this.x = this.x + a;
            if (this.x < 0)
            {
                throw new ArgumentException("Координата X должна быть неотрицательной");
            }
            this.m = this.m++;

        }

        public void shiftY(int a)
        {
            this.y = this.y + a;
            if (this.y < 0)
            {
                throw new ArgumentException("Координата Y должна быть неотрицательной");
            }
            this.m = this.m++;
        }

        public void stretchX(int a)
        {
            this.w = this.w + a;
            if (this.w < 0)
            {
                throw new ArgumentException("Ширина должна быть положительной");
            }
            this.m = this.m++;
        }

        public void stretchY(int a)
        {
            this.h = this.h + a;
            if (this.h < 0)
            {
                throw new ArgumentException("Высота должна быть положительной");
            }
            this.m = this.m++;
        }
    }
}
