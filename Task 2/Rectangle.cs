using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson__3__Data_types_
{
    class Rectangle
    {
        double side1;
        double side2;
        //-------------------------------------------------

        public double Area { get { return CalculateArea(); } }

        public double Perimeter { get { return CalculatePerimeter(); } }
        //-------------------------------------------------

        public Rectangle(double side1, double side2)
        {
            this.side1 = side1;
            this.side2 = side2;
        }
        //-------------------------------------------------

        public double CalculateArea()
        {
            return side1 * side2;
        }
        //-------------------------------------------------

        public double CalculatePerimeter()
        {
            return (side1 + side2) * 2;
        }
        //-------------------------------------------------
    }
}
