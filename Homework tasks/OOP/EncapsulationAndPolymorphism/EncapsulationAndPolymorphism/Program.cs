namespace Shapes
{
    using System;

    public class Program
    {
        static void Main(string[] args)
        {
            IShape[] figs = new IShape[]
            {
                new Circle(5),
                new Rectangle(2, 5),
                new Triangle(4, 8, 6)
            };

            foreach (var fig in figs)
            {
                fig.CalculateArea();
                fig.CalculatePerimeter();
            }
        }
    }
}
