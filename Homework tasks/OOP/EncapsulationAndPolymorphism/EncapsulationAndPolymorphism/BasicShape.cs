namespace Shapes
{
    using System;

    public abstract class BasicShape : IShape
    {
        private double width;
        private double height;

        protected double Width { get; set; }
        protected double Height { get; set; }

        protected BasicShape(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        public abstract void CalculateArea();
        public abstract void CalculatePerimeter();
    }
}
