using System;
using System.Collections.Generic;
using System.Text;

namespace ShapeFactory
{
    interface IShape
    {
        double GetArea(int height, int width);
        double GetPerimeter(int height, int width);
    }
}
