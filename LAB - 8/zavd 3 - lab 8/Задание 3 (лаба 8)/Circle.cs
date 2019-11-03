using System;
using System.Collections.Generic;
using System.Text;

namespace Задание_3__лаба_8_
{
    class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(double radius) => Radius = radius;

        public override double CalculateArea()
        { return 3.14 * Math.Pow(Radius,2); }
        public override double CalculatePerimeter()
        { return 2 * 3.14 * Radius; }

        public override string Draw()
        {
            string figure = "";

            figure += "      ##########\n     ";
            figure += "#          #\n";
            figure += "     #          #\n";
            figure += "     #          #\n";
            figure += "     #          #\n";
            figure += "      ##########\n     ";



            return figure;
        }
    }
}
