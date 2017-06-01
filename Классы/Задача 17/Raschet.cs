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

        public void nachalo(string a)
        {
            string filename = "test" + a + ".csv";

            StreamReader reader = new StreamReader(filename);
            while (!reader.EndOfStream)
            {

               

                string r = (reader.ReadLine());
                string[] arr = r.Split(';');
                int k = int.Parse(arr[1]);

                if (arr[0] == "shiftX")
                {
                    shiftX(k);
                    this.m++;
                }

                if (arr[0] == "shiftY")
                {
                    shiftY(k);
                    this.m++;
                }

                if (arr[0] == "stretchX")
                {
                    stretchX(k);
                    this.m++;
                }

                if (arr[0] == "stretchY")
                {
                    stretchY(k);
                    this.m++;
                }

                if (this.x < 0)
                {
                    throw new ArgumentException("Координата X должна быть неотрицательной");
                }

                if (this.y < 0)
                {
                    throw new ArgumentException("Координата Y должна быть неотрицательной");
                }

                if (this.width < 0)
                {
                    throw new ArgumentException("Ширина должна быть положительной");
                }

                if (this.height < 0)
                {
                    throw new ArgumentException("Высота должна быть положительной");
                }


                //else
                //{
                //    throw new ArgumentException("Некорректный формат");
                //}
            }
        }


        public void shiftX(int a)
        {
            this.x = this.x + a;
        }

        public void shiftY(int a)
        {
            this.y = this.y + a;
        }

        public void stretchX(int a)
        {
            this.width = this.width + a;
        }

        public void stretchY(int a)
        {
            this.height = this.height + a;
        }

       


    }
}
