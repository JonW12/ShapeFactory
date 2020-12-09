using System;

namespace ShapeFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = 2;
            int height = 2;
            ShapeFactory shapeFactory = new ShapeFactory();
            Console.WriteLine("Welcome to the Shape Factory");
            Console.WriteLine("Building circle...");
            IShape shape;
            try
            {
                shape = shapeFactory.GetShape("Circle");
                Console.WriteLine($"Area of Circle: {shape.GetArea(height, width)}\nCircumference of Circle: {shape.GetPerimeter(height, width)}");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("Building Square...");
            try
            {
                shape = shapeFactory.GetShape("Square");
                Console.WriteLine($"Area of Square: {shape.GetArea(height, width)}\nPerimeter of Square: {shape.GetPerimeter(height, width)}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("Building Hexagon...");
            try
            {
                shape = shapeFactory.GetShape("Hexagon");
                Console.WriteLine($"Area of Hexagon: {shape.GetArea(height, width)}\nPerimeter of Hexagon: {shape.GetPerimeter(height, width)}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadKey();
        }
    }
}
