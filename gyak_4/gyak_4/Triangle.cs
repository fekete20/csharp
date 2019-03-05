using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gyak_4
{
    class Triangle : Shape
    {
        Point[] _points = new Point[3];


        public override double Area()
        {
            return 1;
        }

        public override double Circumference()
        {
            return 1;
        }



        public Triangle(Point p1, Point p2, Point p3)
        {
            this._points[0] = p1;
            this._points[1] = p2;
            this._points[2] = p3;
           
        }

        public override string ToString()
        {
            return base.ToString();
        }

    }
}
