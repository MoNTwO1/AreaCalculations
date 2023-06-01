using AreaCalculations.Shapes;

namespace AreaCalculations.Creators
{
    public class TriangleCreator : AbstractCreator
    {
        public double SideA { get; set; }
        public double SideB { get; set; }
        public double SideC { get; set; }
        public TriangleCreator(double sideA, double sideB, double sideC)
        {
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }

        public override AbstractShape Create()
        {
            return new Triangle(SideA, SideB, SideC);
        }
    }
}
