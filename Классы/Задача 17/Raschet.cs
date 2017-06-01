using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_17
{
    class Raschet
    {
        public int x = 100;
        public int y = 100;
        public int width = 100;
        public int height = 100;
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
                throw new ArgumentException("Некорректное действие: "+ action);
            }
            this.m++;
        }

        

        public void shiftX(int a)
        {
            this.x = this.x + a;
            if (this.x < 0)
            {
                throw new ArgumentException("Координата X должна быть неотрицательной");
            }
        }

        public void shiftY(int a)
        {
            this.y = this.y + a;
            if(this.y < 0)
                {
                throw new ArgumentException("Координата Y должна быть неотрицательной");
            }
        }

        public void stretchX(int a)
        {
            this.width = this.width + a;
            if (this.width < 0)
            {
                throw new ArgumentException("Ширина должна быть положительной");
            }
        }

        public void stretchY(int a)
        {
            this.height = this.height + a;
            if (this.height < 0)
            {
                throw new ArgumentException("Высота должна быть положительной");
            }
        }

        public string Print()
        {
            return "действий: " + m + " {\"x\":" + x + ",\"y\":" + y + ",\"w\":" + width + ",\"h\":" + height +"}";
        }

       


    }
}
