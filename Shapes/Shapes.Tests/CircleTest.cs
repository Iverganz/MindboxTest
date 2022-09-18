using Shapes.Core;
using System;
using Xunit;

namespace Shapes.Tests
{
    public class CircleTest
    {
        [Fact]
        public void CreateCircle_ArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new Circle(-1));
        }

        [Fact]
        public void GetCircleArea_Success()
        {
            var circle = new Circle(3);
            Assert.Equal(Math.PI * 3 * 3, circle.Area);
        }
    }
}
