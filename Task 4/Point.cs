using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson__3__Data_types_.Task_4
{
    class Point
    {
        int x;
        int y;
        //------------------------------------------------

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        //------------------------------------------------

        public int X { get { return x; } }
        public int Y { get { return y; } }
        //------------------------------------------------
    }
}
