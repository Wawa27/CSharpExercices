using System;

namespace CS.Impl._04_Advanced
{
    public abstract class Shape
    {
        public abstract double GetArea();

        public abstract double GetPerimeter();

        public override string ToString()
        {
            return GetType().Name;
        }
    }

    public class Circle : Shape
    {
        private double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public override double GetArea()
        {
            return Math.Round(Math.PI * Radius * Radius);
        }

        public override double GetPerimeter()
        {
            return Math.Round(Math.PI * 2 * Radius);
        }
    }

    public class Rectangle : Shape
    {
        private double Length { get; set; }
        private double Width { get; set; }

        public Rectangle(double length, double width)
        {
            Length = length;
            Width = width;
        }

        public override double GetArea()
        {
            return Length * Width;
        }

        public override double GetPerimeter()
        {
            return Length * 2 + Width * 2;
        }
    }

    public class Square : Shape
    {
        private double SideLength { get; set; }

        public Square(double sideLength)
        {
            SideLength = sideLength;
        }

        public override double GetArea()
        {
            return SideLength * SideLength;
        }

        public override double GetPerimeter()
        {
            return SideLength * 4;
        }
    }
}