using System;
using Shape;


namespace ShapeTest
{
    [TestClass]
    public class BasicShapeTests
    {

        [TestMethod]
        public void BasicShapePerimitterTest()
        {
            basicShape basicShape = new basicShape(20);
            double perimitterExpected = 40;
            double perimitterActual = basicShape.Perimitter();

            Assert.AreEqual(perimitterExpected, perimitterActual);
        }

        [TestMethod]
        public void BasicShapeAreaTest()
        {
            basicShape basicShape = new basicShape(20);
            double perimitterExpected = 40;
            double perimitterActual = basicShape.Area();

            Assert.AreEqual(perimitterExpected, perimitterActual);
        }

        [TestMethod]
        public void TrianglePerimiterTest()
        {
            Triangle triangleShape = new Triangle(20, 20);
            double perimitterExpected = 60;
            double perimitterActual = triangleShape.Perimitter();

            Assert.AreEqual(perimitterExpected, perimitterActual);

        }

        [TestMethod]
        public void TriangleAreaTest()
        {
            Triangle triangleShape = new Triangle(20, 20);
            double areaExpected = 200;
            double areaActual = triangleShape.Area();

            Assert.AreEqual(areaExpected, areaActual);

        }

        [TestMethod]
        public void SquarePerimiterTest()
        {
            Square squareShape = new Square(20);
            double perimitterExpected = 80;
            double perimitterActual = squareShape.Perimitter();

            Assert.AreEqual(perimitterExpected, perimitterActual);
        }

        [TestMethod]
        public void SquareAreaTest()
        {
            Square squareShape = new Square(20);
            double areaExpected = 400;
            double areaActual = squareShape.Area();

            Assert.AreEqual(areaExpected, areaActual);

        }
        [TestMethod]
        public void CirclePerimitterTest()
        {
            Circle circleShape = new Circle(20);
            double perimitterExpected = 125.66;
            double perimitterActual = circleShape.Perimitter();

            Assert.AreEqual(perimitterExpected, perimitterActual);
        }

        [TestMethod]
        public void CircleAreaTest()
        {
            Circle circleShape = new Circle(20);
            double areaExpected = 1256.61;
            double areaActual = circleShape.Area();

            Assert.AreEqual(areaExpected, areaActual, 0.05);
        }
    }
}