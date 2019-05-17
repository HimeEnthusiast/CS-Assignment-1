using System;

namespace ShapeApp
{
    // name:Vinay
    // student number: 99999999
    // date: 12-May-2019
    class ShapeTest
    {
        static void Main(string[] args)
        {
            Shape shape1 = new Shape(10.5, 4.6);   // Declare shape1 of type Shape
            Shape shape2 = new Shape(9.6, 3.2);   // Declare shape2 of type Shape
            double area;
            // Area of shape 1
            area = shape1.calculateArea();
            Console.WriteLine($"Area of Shape1 = {area}");
            // Area of shape 2
            area = shape2.calculateArea();
            Console.WriteLine($"Area of Shape2 = {area}");

        }
    }
}
