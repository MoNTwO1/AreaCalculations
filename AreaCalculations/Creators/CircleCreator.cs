using AreaCalculations.Shapes;

namespace AreaCalculations.Creators
{
    public class CircleCreator : AbstractCreator
    {
        public double Radius { get; set; }
        public CircleCreator(double radius)
        {
            Radius = radius;
        }
        public override AbstractShape Create()
        {
            return new Circle(Radius);
        }

    }
}
