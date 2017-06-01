using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_18
{
    class Raschet
    {   

        public int cx=150;
        public int cy = 150;
        public int r = 100;
        public int m = 0;

        public void Selectaction(string action, int value)
        {
            if (action == "shiftX")
            {
                shiftX(value);
            }
            else if (action == "shiftY")
            {
                shiftY(value);
            }
            else if (action == "stretchX")
            {
                stretchX(value);
            }
            else if (action == "stretchY")
            {
                stretchY(value);
            }

            else
            {
                throw new ArgumentException("Некорректное действие: " + action);
            }
            this.m++;
        }

        public void shiftX(int a)
        {
            this.cx = this.cx + a;
            if (this.cx < this.r)
            {
                throw new ArgumentException("Левая точка круга должна иметь неотрицательные координаты");
            }
        }

        public void shiftY(int a)
        {
            this.cy = this.cy + a;
            if (this.cy < this.r)
            {
                throw new ArgumentException("Верхняя точка круга должна иметь неотрицательные координаты");
            }
        }

        public void stretchX(int dw)
        {
            this.r = this.r + dw/2;
            this.cx = this.cx + dw / 2;
            this.cy = this.cy + dw / 2;
            if (this.r < 0)
            {
                throw new ArgumentException("Ширина должна быть положительной");
            }
        }

        public void stretchY(int dw)
        {
            this.r = this.r + dw / 2;
            this.cx = this.cx + dw / 2;
            this.cy = this.cy + dw / 2;
            if (this.r < 0)
            {
                throw new ArgumentException("Высота должна быть положительной");
            }
        }

        public string Print()
        {
            return "действий: " + m + "{ \"cx\": "+cx+",\"cy\": "+cy+",\"r\": "+r+"}";
        }


    }
}
