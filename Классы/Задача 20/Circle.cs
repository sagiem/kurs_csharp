using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_20
{
    class Circle : IMovable
    {
        private int cx = 0;
        private int y = 0;
        private int r = 0;
        private int m = 0;

        public Circle(int cx, int y, int r)
        {
            this.cx = cx;
            this.y = y;
            this.r = r;
        }


        public void shiftX(int a)
        {
            this.cx = this.cx + a;
            if (this.cx < this.r)
            {
                throw new ArgumentException("Левая точка круга должна иметь неотрицательные координаты");
            }
            this.m = this.m++;
        }

        public void shiftY(int a)
        {
            this.y = this.y + a;
            if (this.y < this.r)
            {
                throw new ArgumentException("Верхняя точка круга должна иметь неотрицательные координаты");
            }
            this.m = this.m++;
        }

        public void stretchX(int dw)
        {
            this.r = this.r + dw / 2;
            this.cx = this.cx + dw / 2;
            this.y = this.y + dw / 2;
            if (this.r < 0)
            {
                throw new ArgumentException("Ширина должна быть положительной");
            }
            this.m = this.m++;
        }

        public void stretchY(int dw)
        {
            this.r = this.r + dw / 2;
            this.cx = this.cx + dw / 2;
            this.y = this.y + dw / 2;
            if (this.r < 0)
            {
                throw new ArgumentException("Высота должна быть положительной");
            }
            this.m = this.m++;
        }

        public override string ToString()
        {
            return "действий: " + m + " {\"cx\":" + cx + ",\"y\":" + y + ",\"r\":" +r+"}";
        }

    }
}
