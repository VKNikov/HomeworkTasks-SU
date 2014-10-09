namespace Shapes
{
    using System;

    public class Rectangle : BasicShape
    {
        // Again, the same as in the triangle's case. I will use the fields in the base class to store the variables a and b.
        public Rectangle(double a, double b) : base(a, b)
        {
        }

        public override void CalculateArea()
        {
            double area = base.Width * base.Height;
            Console.WriteLine("The area of a rectangle with side a {0} and side b {1} is {2}", base.Width, base.Height, area);
        }

        public override void CalculatePerimeter()
        {
            double perimeter = 2 * (this.Width + this.Height);
            Console.WriteLine("The perimeter of a rectangle with side a {0} and side b {1} is {2}", this.Width, this.Height, perimeter);
        }
    }
}
