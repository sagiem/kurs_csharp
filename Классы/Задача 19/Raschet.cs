using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_19
{
    class Raschet
    {
        Dictionary<string, Rectangle> dir = new Dictionary<string, Rectangle>();

        public void Selectaction(string line)
        {
            string[] arr = line.Split(';');
            string action = arr[0];

            if(arr[0]== "create")
            {
                if (arr.Length == 6)
                {
                    int x = int.Parse(arr[2]);
                    int y = int.Parse(arr[3]);
                    int w = int.Parse(arr[4]);
                    int h = int.Parse(arr[4]);
                    Rectangle Rec = new Rectangle(x, y, w, h);
                    dir.Add(arr[1], Rec);
                }
                else
                {
                    throw new ArgumentException("Некорректный формат");
                }


            }

            if (arr.Length != 3)
            {
                throw new ArgumentException("Некорректный формат");
            }

            if (!dir.ContainsKey(arr[1]))
            {

                throw new ArgumentException("Некорректный формат");
            }

            Rectangle figure = dir[arr[1]];
            int value = int.Parse(arr[2]);

            if (action == "shiftX")
            {              
                figure.shiftX(value);
            }
            else if (action == "shiftY")
            {
                figure.shiftY(value);
            }
            else if (action == "stretchX")
            {
                figure.stretchX(value);
            }
            else if (action == "stretchY")
            {
                figure.stretchY(value);
            }

            else
            {
                throw new ArgumentException("Некорректное действие: " + action);
            }    
        }

    }
}
