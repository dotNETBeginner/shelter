using System;
using System.Collections.Generic;
using System.Text;

namespace Задание_3__лаба_8_
{
    class Rectangle : Shape
    {
        public double Height { get; set; }
        public double Width { get; set; }

        public Rectangle(double height, double width)
        {
            Height = height;
            Width = width;
        }

        public override double CalculateArea()
        { return Height * Width; }
        public override double CalculatePerimeter()
        { return 2 * (Height + Width); }

        public override string Draw()
        {
            string figure = "";

            int n = (int)Height;
            int m = (int)Width + 2;

            for (int i=0; i < n; i++)
                for(int j=0; j < m; j++)
                {
                    if((j != 0 && j != m - 1) && (i == 0 || i == n - 1)) { figure += "-"; }
                    else if (j == 0) { figure += "|"; }
                    else if (j == m - 1) { figure += "|\n"; }
                    else { figure += " "; }
                }

            return figure;
        }
    }
}
