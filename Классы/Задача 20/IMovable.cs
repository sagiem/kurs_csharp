using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_20
{
    interface IMovable
    {
        void shiftX(int value);
        void shiftY(int value);
        void stretchX(int value);
        void stretchY(int value);
    }
}
