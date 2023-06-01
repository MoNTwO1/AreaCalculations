namespace AreaCalculations.Shapes
{
    class Circle : AbstractShape
    {
        public double Radius { get; }

        public Circle(double radius)
        {
            if (Validate(radius))
                throw new ArgumentException("Радиус не может быть меньше 0");
            Radius = radius;
        }

        public override double CalculateArea()
        {
            return Math.PI * Math.Pow(Radius, 2d);
        }

        public bool Validate(double radius)
        {
            return radius <= 0;
        }
    }
}