using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gyak_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle c1;
            Triangle t1;

            c1 = new Circle(5, new Point(1, 2));

            t1 = new Triangle(new Point(0, 1), new Point(2, 3), new Point(4, 5));

             Console.WriteLine(c1);
        }
    }
}
