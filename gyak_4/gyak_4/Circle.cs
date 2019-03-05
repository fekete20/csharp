using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gyak_4
{
    class Circle : Shape
    {
        private double _radius;
        private Point _center;

        public override double Area()
        {
            return 1;
        }

        public override double Circumference()
        {
            return 1;
        }


        public Circle(double radius, Point center)
        {
            this._radius = radius;
            this._center = center;
        }

        public override string ToString()
        {
            return "kör";
        }

    }
}
