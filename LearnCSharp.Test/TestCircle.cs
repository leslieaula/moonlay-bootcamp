using System;
using Xunit;

namespace LearnCSharp.Test
{
    public class TestCircle
    {
        [Fact]
        public void Circle_Should_Having_Ruas()
        {
            var circle = new Circle(7);

            Assert.NotEqual(0, circle.Ruas);
        }

        [Fact]
        public void Should_Give_Correct_Area()
        {
            var testValue = (double)1;
            var circle = new Circle(testValue);
            var correctArea = Math.PI * testValue * testValue;

            Assert.Equal(correctArea, circle.GetArea());

        }

        [Fact]
        public void Should_Give_Correct_Keliling()
        {
            var testValue = (double)1;
            var circle = new Circle(testValue);
            var correctArea = 2 * Math.PI * testValue;

            Assert.Equal(correctArea, circle.GetKeliling());
        }

    }
}
