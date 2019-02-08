using System;
using Xunit;

namespace UnitTests
{
    public class UnitTest1
    {
        [Fact]
      public void Area_WorksWithTwoPositiveIntegers()
        {
            var expected = 8;
            var a = 2;
            var b = 2; 
            var actual = AreaofRectangle(a, b);
            Assert.Equal(expected,actual);
        }
        [Theory]
        [InlineData(8,2,2)]
        [InlineData(-24, -7,-5)]
        [InlineData(0, 0,0)]
        public void Area_WorksWithManyInputs(int exp, int n1, int n2)
        {
            Assert.Equal(exp, AreaofRectangle(n1, n2));
        }
            [Fact]
      public void Volume_WorksWithTwoPositiveNumbers()
        {
            var expected = 25.12;
            var a = 2.0;
            var b = 2.0; 
            var actual = VolumeofCylinder(a, b);
            Assert.Equal(expected,actual);
        }
          [Theory]
        [InlineData(25.12,2.0,2.0)]
        [InlineData(-25.12, -2.0,-2.0)]
        [InlineData(0.0, 0.0,0.0)]
        public void Volume_WorksWithManyInputs(double exp, double n1, double n2)
        {
            Assert.Equal(exp, VolumeofCylinder(n1, n2));
        }

         int AreaofRectangle(int x, int y)
        {
            return 2*(x + y);
        }
        double VolumeofCylinder(double x, double y)
        {
            return 3.14*x*x*y;
        }
    }
}
