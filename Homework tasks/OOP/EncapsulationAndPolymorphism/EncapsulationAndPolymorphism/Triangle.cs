namespace Shapes
{
    using System;

    public class Triangle : BasicShape
    {
        // In order to use the base fields and not to create new ones, I will asign a and b to the base's width and height.
        // I know this may not be the best practice to assign values to a variable with incorrect name, but on the other hand it allows me to reuse the code in the base class
        // and reduces the need to type more code.
        public Triangle(double a, double b, double c)
            : base(a, b)
        {
            this.C = c;
        }

        public double C { get; set; }

        // I am using the Heron's formula for this.
        public override void CalculateArea()
        {
            double semiperimeter = (this.Width + this.Height + this.C) / 2;
            double area = Math.Sqrt(semiperimeter * (semiperimeter - this.Width) * (semiperimeter - this.Height) * (semiperimeter - this.C));
            Console.WriteLine("The area of the triangle with side a {0}, side b {1}, and side c {2} is {3}.", this.Width, this.Height, this.C, area);
        }

        public override void CalculatePerimeter()
        {
           double perimeter = this.Width + this.Height + this.C;
           Console.WriteLine("The perimeter of the triangle with side a {0}, side b {1}, and side c {2} is {3}.", this.Width, this.Height, this.C, perimeter);
        }
    }
}
