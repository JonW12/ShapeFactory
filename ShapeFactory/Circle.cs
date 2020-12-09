using System;
using System.Collections.Generic;
using System.Text;

namespace ShapeFactory
{
    class Circle : IShape
    {
        public double GetArea(int height, int width)
        {
            double area = Math.Round(Math.Pow(height / 2, 2) * Math.PI, 2);
            return area;
        }

        public double GetPerimeter(int height, int width)
        {
            double circumference = Math.PI * height;
            return circumference;
        }
    }
}
