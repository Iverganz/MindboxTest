using Shapes.Core;
using System;
using Xunit;

namespace Shapes.Tests
{
    public class TriangleTest
    {
        [Theory]
        [InlineData(-1, 1, 1)]
        [InlineData(1, -1, 1)]
        [InlineData(1, 1, -1)]
        [InlineData(1, 1, 2)]
        public void CreateTriangle_ArgumentException(double sideA, double sideB, double sideC)
        {
            Assert.Throws<ArgumentException>(() => new Triangle(sideA, sideB, sideC));
        }

        [Fact]
        public void TriangleArea_Success()
        {
            var triangle = new Triangle(3, 4, 5);
            Assert.Equal(6, triangle.Area);
        }

        [Fact]
        public void TriangleIsRight_Success()
        {
            var triangle = new Triangle(3, 4, 5);
            Assert.True(triangle.IsRight);
        }
    }
}