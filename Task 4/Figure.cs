using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson__3__Data_types_.Task_4
{
    class Figure
    {
        Point[] points = null;
       public string type = null;
        //---------------------------------------------------------------

        public Figure(Point p1, Point p2, Point p3)
        {
            points = new Point[3];
            points[0] = p1;
            points[1] = p2;
            points[2] = p3;
            type = "Triangle";
        }
        //---------------------------------------------------------------

        public Figure(Point p1, Point p2, Point p3, Point p4)
        {
            points = new Point[4];
            points[0] = p1;
            points[1] = p2;
            points[2] = p3;
            points[3] = p4;
            type = "Rectangle";
        }
        //---------------------------------------------------------------

        public Figure(Point p1, Point p2, Point p3, Point p4, Point p5)
        {
            points = new Point[5];
            points[0] = p1;
            points[1] = p2;
            points[2] = p3;
            points[3] = p4;
            points[4] = p5;
            type = "Pentagon";
        }
        //---------------------------------------------------------------

        public double CalcLengthRectangle(Point A, Point B)
        {
           return Math.Sqrt(Math.Pow((A.X - B.X), 2) + Math.Pow((B.Y - B.Y), 2));
        }
        //---------------------------------------------------------------

        public void PerimeterCalculator()
        {
            double sum = 0.0;
            for(int i = 0; i < points.Length -1; i++)
            {
                sum += CalcLengthRectangle(points[i], points[i + 1]);
            }
            sum += CalcLengthRectangle(points[points.Length - 1], points[0]);
            Console.WriteLine(sum);
        }
    }
}
