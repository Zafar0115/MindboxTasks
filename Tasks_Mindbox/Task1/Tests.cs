using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Tasks_Mindbox.Task1
{
    public class Tests
    {
        [Fact]
        public void CircleAreaCalculation()
        {
            Circle circle = new Circle(5);
            double expectedArea = Math.PI * 25;

            Assert.Equal(expectedArea, circle.CalculateArea(), 3);
        }

        [Fact]
        public void TriangleAreaCalculation()
        {
            Triangle triangle = new Triangle(3, 4, 5);
            double expectedArea = 6;

            Assert.Equal(expectedArea, triangle.CalculateArea(), 3);
        }

        [Fact]
        public void RightTriangleCheck()
        {
            Triangle rightTriangle = new Triangle(3, 4, 5);
            Triangle nonRightTriangle = new Triangle(3, 4, 6);

            Assert.True(rightTriangle.IsRightTriangle());
            Assert.False(nonRightTriangle.IsRightTriangle());
        }
    }
}
