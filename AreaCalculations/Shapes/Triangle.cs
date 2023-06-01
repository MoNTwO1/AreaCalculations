namespace AreaCalculations.Shapes
{
    public class Triangle : AbstractShape
    {
        public double SideA { get; }
        public double SideB { get; }
        public double SideC { get; }
        public bool IsRightTriangle { get; }
        public Triangle(double sideA, double sideB, double sideC)
        {
            if (Validate(sideA, sideB, sideC))
                throw new ArgumentException("Треугольник с такими сторонами не может существовать");
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
            IsRightTriangle = CheckIsRightTriangle();

        }

        public override double CalculateArea()
        {
            var p = (SideA + SideB + SideC) / 2;
            return Math.Sqrt(p*(p-SideA)*(p-SideB)*(p-SideC));
        }

        public bool CheckIsRightTriangle()
        {
            List<double> doubles = new() { SideA, SideB, SideC };
            doubles.Sort();
            return doubles[0]* doubles[0] + doubles[1]*doubles[1] == doubles[2]*doubles[2];
        }

        public bool Validate(double sideA, double sideB, double sideC)
        {
            return sideA > sideB + sideC
                || sideB > sideA + sideC
                || sideC > sideA + sideB
                || sideA <= 0
                || sideB <= 0
                || sideC <= 0
                ;

        }
    }
}
