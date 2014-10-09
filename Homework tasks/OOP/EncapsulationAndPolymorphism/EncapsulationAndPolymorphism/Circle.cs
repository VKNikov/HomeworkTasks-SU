namespace Shapes
{
    using System;

    public class Circle : IShape
    {
        public Circle(double radius)
        {
            this.Radius = radius;
        }

        public double Radius { get; set; }

        public void CalculateArea()
        {
            double area = Math.PI * this.Radius * this.Radius;
            Console.WriteLine("The area of a circle with radius {0} is {1}", this.Radius, area);
        }

        public void CalculatePerimeter()
        {
            double perimeter = 2 * Math.PI * this.Radius;
            Console.WriteLine("The perimeter of a circle with radius {0} is {1}", this.Radius, perimeter);
        }
    }
}
