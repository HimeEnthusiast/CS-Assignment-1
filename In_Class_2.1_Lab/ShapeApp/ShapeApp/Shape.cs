using System;
using System.Collections.Generic;
using System.Text;
// name:Vinay
// student number: 99999999
// date: 12-May-2019
namespace ShapeApp
{
    class Shape
    {
        private double length;   // Length of a shape
        private double width;   // width of a shape
        public Shape(double l, double w)
        {
            length = l;
            width = w;
        }
        public double calculateArea()
        {
            return (length * width);
        }
    }
}
