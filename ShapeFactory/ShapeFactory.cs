using System;
using System.Collections.Generic;
using System.Text;

namespace ShapeFactory
{
    class ShapeFactory
    {
        public IShape GetShape(string shapeName)
        {
            switch (shapeName)
            {
                case "Circle":
                    return new Circle();
                case "Square": 
                    return new Square();
                default:
                    throw new Exception($"Sorry this shape ({shapeName}) is not yet implemented");
            }
        }
    }
}
