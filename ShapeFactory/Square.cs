using System;
using System.Collections.Generic;
using System.Text;

namespace ShapeFactory
{
    class Square : IShape
    {
        public double GetArea(int height, int width)
        {
            double area = height * width;
            return area;
        }

        public double GetPerimeter(int height, int width)
        {
            double perimeter = (2 * height) + (2 * width);
            return perimeter;
        }
    }
}
