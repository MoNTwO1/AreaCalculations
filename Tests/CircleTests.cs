using NUnit.Framework;
using System;
using AreaCalculations.Creators;
using AreaCalculations.Shapes;
namespace Tests
{
    [TestFixture]
    public class CircleTests
    {
        [SetUp]
        public void Setup()
        {
            
        }

        [Test]
        public void CalculateCircleArea()
        {
            double radius = 3.0;
            var expectedArea = radius * radius * Math.PI;

            AbstractCreator creator = new CircleCreator(3.0);
            var circle = creator.Create();
            var actualArea = circle.CalculateArea();
            
            Assert.That(actualArea, Is.EqualTo(expectedArea));
        }

        [Test]
        [TestCase(-3.0)]
        [TestCase(0)]
        public void CannotCreateCircle(double radius)
        { 

            AbstractCreator creator = new CircleCreator(radius);

            Assert.Catch<ArgumentException>(() => creator.Create());
        }

    }
}