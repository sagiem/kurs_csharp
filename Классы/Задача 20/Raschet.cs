using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_20
{
    class Raschet
    {
        
        Dictionary<string, IMovable> dir2 = new Dictionary<string, IMovable>();

        public void Selectaction(string line)
        {
            string[] arr = line.Split(';');
            string action = arr[0];

            if (arr[0] == "create")
            {
                if (arr.Length != 6 && arr.Length !=7)
                {
                    throw new ArgumentException("Некорректный формат");
                }

                if(arr[1]== "rectangle")
                {
                    int x = int.Parse(arr[3]);
                    int y = int.Parse(arr[4]);
                    int w = int.Parse(arr[5]);
                    int h = int.Parse(arr[6]);
                    Rectangle Rec = new Rectangle(x, y, w, h);
                    dir2.Add(arr[2], Rec);
                }

                else if (arr[1] == "circle")
                {
                    int cx = int.Parse(arr[3]);
                    int y = int.Parse(arr[4]);
                    int r = int.Parse(arr[5]);

                    Circle Reccir = new Circle(cx, y, r);;
                    dir2.Add(arr[2], Reccir);

                }

                else
                {

                    throw new ArgumentException("Неизвестная фигура");
                }
            }

            if (arr.Length != 3 && arr.Length != 6 && arr.Length != 7)
            {
                throw new ArgumentException("Некорректный формат");
            }

            
            

            if (dir2.ContainsKey(arr[1]))
            {

                IMovable figure1 = dir2[arr[1]];
                int value = int.Parse(arr[2]);

                if (action == "shiftX")
                {

                    figure1.shiftX(value);
                }
                else if (action == "shiftY")
                {
                    figure1.shiftY(value);
                }
                else if (action == "stretchX")
                {
                    figure1.stretchX(value);
                }
                else if (action == "stretchY")
                {
                    figure1.stretchY(value);
                }

                else
                {
                    throw new ArgumentException("Некорректное действие: " + action);
                }
               
            }
         
        }

        public Dictionary<string, IMovable> getcollection()
        {
            return dir2;
        }


    }
}
