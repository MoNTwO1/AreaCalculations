using NUnit.Framework;
using System;
using AreaCalculations.Creators;
using AreaCalculations.Shapes;
namespace Tests
{
    [TestFixture]
    public class TriangleTests
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        [TestCase(-1, 1, 1)]
        [TestCase(1, -1, 1)]
        [TestCase(1, 1, -1)]
        [TestCase(0, 1, 1)]
        [TestCase(3, 4, 10)]
        public void CannotCreateTriangle(double a, double b, double c)
        {

            AbstractCreator creator = new TriangleCreator(a, b, c);

            Assert.Catch<ArgumentException>(() => creator.Create());
        }

        [Test]
        public void CheckIsRightTriangle_False()
        {
            double a = 4.0;
            double b = 4.0;
            double c = 5.0;

            Triangle triangle = new Triangle(a, b, c);
            Assert.False(triangle.IsRightTriangle);
        }

        [Test]
        public void CalculateTriangleArea()
        {
            double a = 3.0;
            double b = 4.0;
            double c = 5.0;
            var p = (a + b + c) / 2;
            var s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));

            AbstractCreator abstractCreator = new TriangleCreator(a, b, c);
            var triangle = abstractCreator.Create();
            Assert.That(triangle.CalculateArea(), Is.EqualTo(s));
        }


    }
}