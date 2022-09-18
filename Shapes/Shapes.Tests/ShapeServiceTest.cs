using Shapes.Core;
using System;
using Xunit;

namespace Shapes.Tests
{
    public class ShapeServiceTest
    {
        [Fact]
        public void CreateShapeService_ArgumentException()
        {
            Assert.Throws<ArgumentNullException>(() => new ShapeAreaService(null));
        }

        [Fact]
        public void TriangleArea_Success()
        {
            var triangle = new Triangle(3, 4, 5);
            var service = new ShapeAreaService(triangle);
            Assert.Equal(6, service.GetArea());
        }


        [Fact]
        public void CircleArea_Success()
        {
            var circle = new Circle(3);
            var service = new ShapeAreaService(circle);
            Assert.Equal(Math.PI *3*3, service.GetArea());
        }
    }
}
